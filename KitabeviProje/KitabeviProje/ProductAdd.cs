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
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");

        private void kategori()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from kategoribilgi", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categorycomboBox.Items.Add(reader["kategori"].ToString());
            }
            connection.Close();
        }
        private void ProductAdd_Load(object sender, EventArgs e)
        {
            kategori();
        }

        private void categorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            markacomboBox.Items.Clear();
            markacomboBox.Text = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from markabilgi where kategori='"+categorycomboBox.SelectedItem+"'", connection); //kategoriye göre marka seçimi yapma
            
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                markacomboBox.Items.Add(reader["marka"].ToString());
            }
            
            connection.Close();
        }

        private void newproductbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into ürün(barkodno,kategori,marka,yazar_adı,urunadi,miktari,alisfiyat,satisfiyat,tarih) " +
                "values(@barkodno,@kategori,@marka,@yazar_adı,@urunadi,@miktari,@alisfiyat,@satisfiyat,@tarih)", connection);
            cmd.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            cmd.Parameters.AddWithValue("@kategori", categorycomboBox.Text);
            cmd.Parameters.AddWithValue("@marka", markacomboBox.Text);
            cmd.Parameters.AddWithValue("@yazar_adı", yazarcomboBox.Text);
            cmd.Parameters.AddWithValue("@urunadi", textBox2.Text);
            cmd.Parameters.AddWithValue("@miktari", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@alisfiyat", double.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@satisfiyat", double.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürünler eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            markacomboBox.Items.Clear();
            foreach  (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void miktarlabel_Click(object sender, EventArgs e)
        {

        }

        private void markacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yazarcomboBox.Items.Clear();
            yazarcomboBox.Text = "";
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("select *from kitapbilgi where marka='" + markacomboBox.SelectedItem + "'", connection); //markaya göre yazar seçimi yapma
            SqlDataReader read = cmd1.ExecuteReader();
            while (read.Read())
            {
                yazarcomboBox.Items.Add(read["yazar_adı"].ToString());
            }
            connection.Close();
        }
    }
}
