using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace PastaneStokVeSiparişTakibi
{
    public partial class CheckPage : Form
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;
        public CheckPage()
        {
            InitializeComponent();
        }

        private void getCheckButton_Click(object sender, EventArgs e)
        {
            if (deskNumberTextBox.Text == "")
            {
                MessageBox.Show("Masa numarasi boş bırakılamaz. Lütfen masa numarasını giriniz.", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlDocument orderXml = new XmlDocument();
                orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
                XmlElement root = orderXml.DocumentElement;
                string orderAddress = deskNumberTextBox.Text;
                XmlNode order = root.SelectSingleNode("order[orderAddress = '" + orderAddress + "']");


                foreach (XmlNode item in order.SelectNodes("orderItem"))
                {

                    string sqlCommandText = "SELECT product_price FROM products WHERE product_name = '" + item.InnerText + "'";
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sqlCommandText;
                    command.ExecuteNonQuery();
                    DataTable products = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(products);

                    string[] row = { item.InnerText, products.Rows[0][0].ToString() };
                    ListViewItem itemRow = new ListViewItem(row);
                    OrderListView.Items.Add(itemRow);
                    int total = 0;
                    foreach (ListViewItem price in OrderListView.Items)
                    {
                        total += Int32.Parse(price.SubItems[1].Text);
                    }

                    TotalCheckLabel.Text = total.ToString();
                }
            }
            
        }

        private void CheckPage_Load(object sender, EventArgs e)
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (deskNumberTextBox.Text == "")
            {
                MessageBox.Show("Masa numarasi boş bırakılamaz. Lütfen masa numarasını giriniz.", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlDocument orderXml = new XmlDocument();
                orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
                XmlElement root = orderXml.DocumentElement;
                string orderAddress = deskNumberTextBox.Text;
                XmlNode order = root.SelectSingleNode("order[orderAddress = '" + orderAddress + "']");

                order.SelectSingleNode("orderAddress").InnerText = orderAddress + " old";
                OrderListView.Items.Clear();
                deskNumberTextBox.Text = "";
                orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");

            }



        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (deskNumberTextBox.Text == "" || moveDeskTextBox.Text == "")
            {
                MessageBox.Show("Masa numarasi boş bırakılamaz. Lütfen masa numarasını giriniz.", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlDocument orderXml = new XmlDocument();
                orderXml.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
                XmlElement root = orderXml.DocumentElement;
                string orderAddress = deskNumberTextBox.Text;
                XmlNode order = root.SelectSingleNode("order[orderAddress = '" + orderAddress + "']");

                order.SelectSingleNode("orderAddress").InnerText = moveDeskTextBox.Text;
                OrderListView.Items.Clear();
                deskNumberTextBox.Text = "";
                moveDeskTextBox.Text = "";
                orderXml.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            }
        }
    }
}
