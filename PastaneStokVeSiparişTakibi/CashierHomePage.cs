using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using CreatingOrderPage;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using Size = System.Drawing.Size;

namespace PastaneStokVeSiparişTakibi
{
    public partial class CashierHomePage : Form
    {
        CreateOrder order;
        private int total_order_number;
        public CashierHomePage()
        {
            InitializeComponent();
            order = elementHost1.Child as CreateOrder;
            total_order_number = 0;

        }
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;
        

        private void CashierHomePage_Load(object sender, EventArgs e)
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
                productBtn.Click += FillOrderItems;
                productBtn.BackgroundImage = Image.FromFile(FileName);
                ProductsFlowLayoutPanel.Controls.Add(productBtn);
                
            }

            foreach (Control cntrl in DesksFlowLayoutPanel.Controls)
            {
                cntrl.Click += FillDeskNumber;
            }
        }

        private void FillOrderItems(object sender, EventArgs e)
        {
            Button productBtn = sender as Button;
            //ListViewItem orderItem = new ListViewItem();
            //orderItem.Text = productBtn.Text;
            string sqlCommandText = "SELECT * FROM stocks WHERE product_id IN (SELECT product_id FROM products WHERE product_name = '" + productBtn.Text + "')";
            
            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();
            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(products);
            if (Int32.Parse( products.Rows[0][1].ToString()) > 0)
            {
                order.order_items_list.Items.Add(productBtn.Text);
                int oldStock = Int32.Parse(products.Rows[0][1].ToString());
                string updateCommand = "UPDATE stocks SET amount = " + (oldStock - 1) +
                                       " WHERE product_id IN (SELECT product_id FROM products WHERE product_name = '" +
                                       productBtn.Text + "')";
                Console.WriteLine(updateCommand);
                MySqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = updateCommand;
                update.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Girdiğiniz ürün stoklarda bulunmamaktadır. Lütfen stoklarınızı kontrol ediniz.",
                    "Ürün Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void FillDeskNumber(object sender, EventArgs e)
        {
            Button deskBtn = sender as Button;
            if (deskBtn.BackColor != Color.DarkRed)
            {
                order.desk.Text = deskBtn.Text;
            }
            else
            {
                MessageBox.Show("Girdiğiniz masa şu anda dolu. Lütfen sipariş eklemek için boş bir masa seçiniz.",
                    "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void OrderListButton_Click_1(object sender, EventArgs e)
        {
            OrderOptions orderPage = new OrderOptions();
            //this.Hide();
            orderPage.Show();
        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            XmlDocument orderXml = new XmlDocument();
            orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            XmlElement root = orderXml.DocumentElement;
            
            if (root.ChildNodes.Count > total_order_number)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    XmlNode deskNode = node.SelectSingleNode("orderAddress");
                    if (deskNode.InnerText.Contains("old"))
                    {
                        string [] address = deskNode.InnerText.Split(new []{' '});
                        string deskName = "Desk" + address[0] + "Button";

                        Control deskButton = Controls.Find(deskName, true)[0];

                        deskButton.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        string deskName = "Desk" + deskNode.InnerText + "Button";

                        Control deskButton = Controls.Find(deskName, true)[0];

                        deskButton.BackColor = Color.DarkRed;
                    }
                    
                    
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void GetCheckButton_Click(object sender, EventArgs e)
        {
            CheckPage checkPage = new CheckPage();
            checkPage.Show();
            checkPage.BringToFront();
        }
    }
}
