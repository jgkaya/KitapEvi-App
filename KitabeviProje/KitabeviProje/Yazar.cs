using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitabeviProje
{
    public partial class Yazar : Form
    {
        public Yazar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        private void Yazar_Load(object sender, EventArgs e)
        {
            kategori();
            marka();
        }
        private void kategori()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from kategoribilgi", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kategori"].ToString());
            }
            connection.Close();
        }
        private void marka()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from markabilgi", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["marka"].ToString());
            }
            connection.Close();
        }

        private void newproductbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into kitapbilgi(kategori,marka,yazar_adı) values('" +comboBox1.Text + "','"+ comboBox2.Text + "','" + textBox8.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBox2.Text = "";
            textBox8.Text = "";
            MessageBox.Show("Yazar başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from markabilgi where kategori='" + comboBox1.SelectedItem + "'", connection); //kategoriye göre marka seçimi yapma
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["marka"].ToString());
            }
            connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
