using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace PastaneStokVeSiparişTakibi
{
    public partial class OrderOptions : Form
    {
        public OrderOptions()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;

        private void OrderOptions_Load(object sender, EventArgs e)
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();

            string sqlCommandText = "SELECT * FROM products WHERE product_id IN (SELECT product_id FROM stocks WHERE amount > 0)";
            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();
            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(products);

            for (int i = 0; i < products.Rows.Count; i++)
            {
                Button productBtn = new Button();
                productBtn.Size = new Size(100, 100);
                productBtn.Text = products.Rows[i][1].ToString();
                string FileName = String.Format("{0}Resources\\" + products.Rows[i][3], Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
                productBtn.BackgroundImageLayout = ImageLayout.Stretch;
                productBtn.TextAlign = ContentAlignment.BottomCenter;
                productBtn.Click += InsertOrderItems;
                productBtn.BackgroundImage = Image.FromFile(FileName);
                ProductsPanel.Controls.Add(productBtn);
            }
            DisplayOrders();
            //calculatePrices();
        }

        public void InsertOrderItems(object sender, EventArgs e)
        {
            Button prdctBtn = sender as Button;
            string sqlCommandText = "SELECT product_price FROM products WHERE product_name = " + "'" + prdctBtn.Text + "'";
            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();
            DataTable price = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(price);
            string[] row = { prdctBtn.Text, price.Rows[0][0].ToString() };
            var listViewItem = new ListViewItem(row);
            
            OrderItemsListView.Items.Add(listViewItem);
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            XmlNode root = orderXml.DocumentElement;
            XmlNode parent = root.SelectSingleNode("order[orderNumber = " + OrdersListView.SelectedItems[0].Text + "]");
            XmlElement newOrderItem = orderXml.CreateElement(string.Empty, "orderItem", string.Empty);
            newOrderItem.InnerText = prdctBtn.Text;
            XmlNode newPrice = parent.SelectSingleNode("orderPrice");
            int oldPrice = Int32.Parse( newPrice.InnerText);
            oldPrice += Int32.Parse(price.Rows[0][0].ToString());
            newPrice.InnerText = oldPrice.ToString();
            parent.AppendChild(newOrderItem);
            TotalPriceLabel.Text = parent.SelectSingleNode("orderPrice").InnerText;
            orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
        }

        public void DisplayOrders()
        {
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            //Console.WriteLine(orderXml.DocumentElement.HasChildNodes);
            //Console.WriteLine(orderXml.DocumentElement.ChildNodes.Count);
            foreach (XmlNode node in orderXml.DocumentElement.ChildNodes)
            {
                string [] order = {node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText, node.ChildNodes[2].InnerText };
                ListViewItem item = new ListViewItem(order);
                OrdersListView.Items.Add(item);
            }
        }

        private void OrdersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            OrderItemsListView.Items.Clear();
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            //Console.WriteLine(OrdersListView.SelectedItems[0].Text);
            XmlNode parent =
                orderXml.DocumentElement.SelectSingleNode("order[orderNumber = " +
                                                          OrdersListView.Items[e.ItemIndex].Text + "]");

            XmlNodeList item_nodes = parent.SelectNodes("orderItem");
           
            for (int i = 0; i < item_nodes.Count; i++)
            {
                string sqlCommandText = "SELECT product_price FROM products WHERE product_name = " + "'" + item_nodes[i].InnerText + "'";
                MySqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();
                DataTable price = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(price);

                Console.WriteLine(item_nodes[i].InnerText);
                string[] order_items = { item_nodes.Item(i).InnerText, price.Rows[0][0].ToString() };
                
                ListViewItem orderItem = new ListViewItem(order_items);
                OrderItemsListView.Items.Add(orderItem);
            }


            TotalPriceLabel.Text = parent.SelectSingleNode("orderPrice").InnerText;

        }

        public void calculatePrices()
        {
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            XmlElement root = orderXml.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int order_price = 0;
                foreach (XmlNode item_node in node.SelectNodes("orderItem"))
                {
                    string sqlCommandText = "SELECT product_price FROM products WHERE product_name = " + "'" + item_node.InnerText + "'";
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sqlCommandText;
                    command.ExecuteNonQuery();
                    DataTable price = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(price);
                   
                    order_price += Int32.Parse( price.Rows[0][0].ToString());
                }
                Console.WriteLine(order_price);
                XmlElement orderPrice = orderXml.CreateElement(string.Empty, "orderPrice", string.Empty);
                orderPrice.InnerText = order_price.ToString();
                node.AppendChild(orderPrice);
            }
            orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            XmlElement root = orderXml.DocumentElement;

            foreach (ListViewItem item in OrderItemsListView.SelectedItems)
            {
                //Console.WriteLine("sub"+item.SubItems[1].Text);
                
                XmlNode parent = root.SelectSingleNode("order[orderNumber = " + OrdersListView.SelectedItems[0].Text + "]");
                int newPrice =Int32.Parse( parent.SelectSingleNode("orderPrice").InnerText);
                newPrice -= Int32.Parse( item.SubItems[1].Text);
                TotalPriceLabel.Text = newPrice.ToString();
                parent.SelectSingleNode("orderPrice").InnerText = newPrice.ToString();
                OrderItemsListView.Items.Remove(item);
                foreach (XmlNode node in parent.ChildNodes)
                {

                    if (node.InnerText == item.SubItems[0].Text)
                    {
                        parent.RemoveChild(node);
                        break;
                    }
                }
                
            }
            orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
        }

        private void OrdersListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
            if (OrdersListView.FocusedItem != null)
            {
                //Do something
                Console.WriteLine("tamamlandi");
                
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
