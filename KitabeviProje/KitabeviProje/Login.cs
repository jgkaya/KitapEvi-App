using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitabeviProje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * 
  FROM[Stok_takibi].[dbo].[giris] Where Kullanıcı = '"+ textBox1.Text+"' and Şifre = '"+textBox2.Text+ "'",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count==1)
            {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre girişi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            clearButton_Click(sender, e);
        }
    }
}
