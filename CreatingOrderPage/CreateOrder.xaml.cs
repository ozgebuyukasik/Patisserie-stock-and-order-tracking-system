using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using MySql.Data.MySqlClient;

namespace CreatingOrderPage
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CreateOrder : UserControl
    {
        public TextBox desk;
        public TextBox order_no;
        public TextBox adress_text;
        public ListView order_items_list;
        public int order_number;
        private XmlDocument orderList;

        public CreateOrder()
        {
            InitializeComponent();
            Loaded += PageLoaded;
            

        }

        public void PageLoaded(object sender, EventArgs e)
        {
            order_number = 1;
            desk = desk_id;
            order_no = order_id;
            order_no.IsReadOnly = true;
            order_no.Text = order_number.ToString();
            adress_text = adress;
            order_items_list = order_items;

            orderList = new XmlDocument();

            //(1) the xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = orderList.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = orderList.DocumentElement;
            orderList.InsertBefore(xmlDeclaration, root);

            //(2) string.Empty makes cleaner code
            XmlElement allOrders = orderList.CreateElement(string.Empty, "orders", string.Empty);
            orderList.AppendChild(allOrders);

            orderList.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");

        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;

            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();
            int index = order_items_list.SelectedIndex;
            string sqlCommandText = "SELECT * FROM stocks WHERE product_id IN (SELECT product_id FROM products WHERE product_name = '" + order_items_list.Items[index].ToString() + "')";

            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();
            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(products);
            int oldStock = Int32.Parse(products.Rows[0][1].ToString());
            
            string updateCommand = "UPDATE stocks SET amount = " + (oldStock + 1) +
                                   " WHERE product_id IN (SELECT product_id FROM products WHERE product_name = '" +
                                   order_items_list.Items[index].ToString() + "')";
            Console.WriteLine(updateCommand);
            MySqlCommand update = connection.CreateCommand();
            update.CommandType = CommandType.Text;
            update.CommandText = updateCommand;
            update.ExecuteNonQuery();
           
            Console.WriteLine(order_items_list.Items[index].ToString());
            order_items_list.Items.RemoveAt(index);

        }
        public void calculatePrices()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;

            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();

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

                    order_price += Int32.Parse(price.Rows[0][0].ToString());
                }
                Console.WriteLine(order_price);
                XmlElement orderPrice = orderXml.CreateElement(string.Empty, "orderPrice", string.Empty);
                orderPrice.InnerText = order_price.ToString();
                node.AppendChild(orderPrice);
            }
            orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
        }
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (order_items_list.Items.Count == 0)
            {
                MessageBox.Show(
                    "Sipariş için gerekli bilgileri eksik girdiniz. Lütfen tekrar kontrol ediniz.",
                    "Eksik Giriş", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (adress_text.Text != "" && desk.Text != "")
                {
                    MessageBox.Show(
                        "Bir sipariş hem masa hem de paket servisi olamaz. Lütfen girdiğiniz bilgileri kontrol ediniz.",
                        "Hatalı Giriş", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if(adress_text.Text == "" && desk.Text == "")
                {
                    MessageBox.Show(
                        "Sipariş için gerekli bilgileri eksik girdiniz. Lütfen tekrar kontrol ediniz.",
                        "Eksik Giriş", MessageBoxButton.OK, MessageBoxImage.Error);
                   
                }
                else
                {
                    XmlDocument orderList = new XmlDocument();
                    orderList.Load("orders.xml");
                    XmlElement root = orderList.DocumentElement;
                    XmlElement order = orderList.CreateElement(string.Empty, "order", string.Empty);
                    XmlElement orderNumber = orderList.CreateElement(string.Empty, "orderNumber", string.Empty);
                    orderNumber.InnerText = order_no.Text;
                    XmlElement orderAddress = orderList.CreateElement(string.Empty, "orderAddress", string.Empty);
                    if (desk.Text == "")
                    {
                        orderAddress.InnerText = adress_text.Text;
                    }
                    else
                    {
                        orderAddress.InnerText = desk.Text;
                    }

                    order.AppendChild(orderNumber);
                    order.AppendChild(orderAddress);
                    XmlElement orderDate = orderList.CreateElement(string.Empty, "orderDate", string.Empty);
                    orderDate.InnerText = DateTime.Now.ToString();
                    order.AppendChild(orderDate);
                    
                    foreach (string orderItem in order_items_list.Items)
                    {

                        XmlElement orderItemElement = orderList.CreateElement(string.Empty, "orderItem", string.Empty);
                        orderItemElement.InnerText = orderItem;
                        order.AppendChild(orderItemElement);
                    }
                    root.AppendChild(order);
                    
                    orderList.Save("orders.xml");
                    order_number ++;
                    calculatePrices();
                    MessageBox.Show("Sipariş başarıyla oluşturuldu. Siparişlerim menüsünden takibini yapabilirsiniz. Sistemin güncelliği için yukarıdaki sistemi güncelle butonuna tıklamayı unutmayınız.",
                        "Sipariş oluşturuldu", MessageBoxButton.OK, MessageBoxImage.Information);
                    desk.Text = "";
                    adress_text.Text = "";
                    order_items_list.Items.Clear();
                    order_no.Text = order_number.ToString();
                    
                }
            }
            
        }
    }
}
