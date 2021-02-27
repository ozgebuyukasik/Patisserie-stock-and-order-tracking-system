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
    public partial class AdminHomePage : Form
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;

        public AdminHomePage()
        {
            InitializeComponent();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {


            string sqlCommandText =
                "SELECT * FROM products WHERE product_id IN (SELECT product_id FROM stocks WHERE amount = 0)";
            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();
            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(products);

            for (int i = 0; i < products.Rows.Count; i++)
            {
                NoStockListView.Items.Add(products.Rows[i][1].ToString());
            }

            XmlDocument ordersXML = new XmlDocument();
            ordersXML.Load(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
            XmlElement root = ordersXML.DocumentElement;

            totalOrderNumberTextBox.Text = root.ChildNodes.Count.ToString();
            int gain = 0;
            foreach (XmlNode node in root.ChildNodes)
            {
                
                XmlNode priceNode = node.SelectSingleNode("orderPrice");
                gain += Int32.Parse(priceNode.InnerText);
            }

            totalGainTextBox.Text = gain.ToString();
        }

        private void addToStockButton_Click(object sender, EventArgs e)
        {
            if (productAmountTextBox.Text == "" || productNameTextBox.Text == "")
            {
                MessageBox.Show("İlgili formdaki girişler boş bırakılamaz. Lütfen tüm bilgileri eksiksiz doldurun.",
                    "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sqlCommandText = "UPDATE stocks SET amount = " + productAmountTextBox.Text +
                                        " WHERE product_id IN (SELECT product_id FROM products WHERE product_name = '" +
                                        productNameTextBox.Text + "')";
                Console.WriteLine(sqlCommandText);
                MySqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();
            }

            string sqlCommandText1 =
                "SELECT * FROM products WHERE product_id IN (SELECT product_id FROM stocks WHERE amount = 0)";
            MySqlCommand command1 = connection.CreateCommand();
            command1.CommandType = CommandType.Text;
            command1.CommandText = sqlCommandText1;
            command1.ExecuteNonQuery();
            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command1);
            adapter.Fill(products);
            NoStockListView.Items.Clear();
            for (int i = 0; i < products.Rows.Count; i++)
            {
                NoStockListView.Items.Add(products.Rows[i][1].ToString());
            }

        }

        private void imagePickerButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPathLabel.Text = openFileDialog.FileName;
            }
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            string prdctName = newProductNameTextBox.Text;
            int prdctPrice = Int32.Parse(NewProductPriceTextBox.Text);
            string prdctCategory = NewProductCategoryTextBox.Text;
            int prdctStock = Int32.Parse(NewProductStockTextBox.Text);
            string [] img = imgPathLabel.Text.Split(new [] {"\\"} , StringSplitOptions.None);
            Console.WriteLine(img[img.Length-1]);
            string FileName = String.Format("{0}Resources\\" + img[img.Length-1], Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
            Console.WriteLine(FileName);
            File.Copy(imgPathLabel.Text,FileName);

            string sqlCommandText = "INSERT INTO products (product_name,product_price,product_img,product_category) " +
                                    "VALUES ('" + prdctName + "', " + prdctPrice + ", '" + img[img.Length - 1] + "', '" + prdctCategory +"')";
            Console.WriteLine(sqlCommandText);
            MySqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlCommandText;
            command.ExecuteNonQuery();

            string selectCommand = "SELECT product_id FROM products WHERE product_name = '" + prdctName + "'";
            MySqlCommand Scommand = connection.CreateCommand();
            Scommand.CommandType = CommandType.Text;
            Scommand.CommandText = selectCommand;
            Scommand.ExecuteNonQuery();

            DataTable products = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Scommand);
            adapter.Fill(products);

            string insertCommand = "INSERT INTO stocks (product_id, amount) VALUES (" + products.Rows[0][0].ToString() +
                                   "," + NewProductStockTextBox.Text + ")";
            Console.WriteLine(insertCommand);
            MySqlCommand Icommand = connection.CreateCommand();
            Icommand.CommandType = CommandType.Text;
            Icommand.CommandText = insertCommand;
            Icommand.ExecuteNonQuery();

            MessageBox.Show("Ürün Oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
            login.BringToFront();
            
        }
    }
}
