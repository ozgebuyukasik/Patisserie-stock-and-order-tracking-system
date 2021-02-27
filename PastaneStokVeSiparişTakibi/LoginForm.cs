using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml;

namespace PastaneStokVeSiparişTakibi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection;
        //private XmlDocument orderList;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "patisserie_db";
            builder.Password = "boxpassword1.";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();

            //orderList = new XmlDocument();

            ////(1) the xml declaration is recommended, but not mandatory
            //XmlDeclaration xmlDeclaration = orderList.CreateXmlDeclaration("1.0", "UTF-8", null);
            //XmlElement root = orderList.DocumentElement;
            //orderList.InsertBefore(xmlDeclaration, root);

            ////(2) string.Empty makes cleaner code
            //XmlElement allOrders = orderList.CreateElement(string.Empty, "orders", string.Empty);
            //orderList.AppendChild(allOrders);

            //orderList.Save(AppDomain.CurrentDomain.BaseDirectory + "orders.xml");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;


            if (userName == "" || password == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılmaz. Lütfen gerekli bilgileri doldurun!", "Geçersiz Giriş Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sqlCommandText = "SELECT password,userRank FROM users WHERE userName = '" + userName + "'";
                MySqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlCommandText;
                command.ExecuteNonQuery();
                DataTable user = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(user);
                if (user.Rows.Count == 1 && user.Rows[0][0].ToString() == password)
                {
                    MessageBox.Show("Hoşgeldiniz!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    if (userName != "admin")
                    {
                        CashierHomePage cashierHP = new CashierHomePage();
                        cashierHP.Show();
                        this.Hide();
                    }
                    else
                    {
                        AdminHomePage adminHP = new AdminHomePage();
                        adminHP.Show();
                        this.Hide();
                    }
                    
                }
                else if (user.Rows.Count == 0)
                {
                    MessageBox.Show("Girdiğınız kullanıcı adı eksik veya hatalıdır. Lütfen tekrar deneyiniz.","Kullanıcı Bulunamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
    }
}
