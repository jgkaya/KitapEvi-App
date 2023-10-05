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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        DataSet set = new DataSet();

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

        private void ProductList_Load(object sender, EventArgs e)
        {
            Products();
            kategori();
        }
        private void Products()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from ürün", connection);
            adapter.Fill(set, "ürün");
            dataGridView1.DataSource = set.Tables["ürün"];
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodtxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            yazartxt.Text = dataGridView1.CurrentRow.Cells["yazar_adı"].Value.ToString();
            uruntxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            miktartxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            alistxt.Text = dataGridView1.CurrentRow.Cells["alisfiyat"].Value.ToString();
            satistxt.Text = dataGridView1.CurrentRow.Cells["satisfiyat"].Value.ToString();

        }

        private void updateproductbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update ürün set urunadi=@urunadi,miktari=@miktari,alisfiyat=@alisfiyat,satisfiyat=@satisfiyat where barkodno=@barkodno",connection);
            cmd.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
            cmd.Parameters.AddWithValue("@urunadi", uruntxt.Text);
            cmd.Parameters.AddWithValue("@miktari", int.Parse(miktartxt.Text));
            cmd.Parameters.AddWithValue("@alisfiyat", double.Parse(alistxt.Text));
            cmd.Parameters.AddWithValue("@satisfiyat", double.Parse(satistxt.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            set.Tables["ürün"].Clear();
            Products();
            MessageBox.Show("Güncelleme yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach  (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (barkodtxt.Text!="")
            {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update ürün set kategori=@kategori,marka=@marka,yazar_adı=@yazar_adı where barkodno=@barkodno", connection);
            cmd.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
            cmd.Parameters.AddWithValue("@kategori", comboBox1.Text);
            cmd.Parameters.AddWithValue("@marka", comboBox2.Text);
            cmd.Parameters.AddWithValue("@yazar_adı", yazarcomboBox.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                set.Tables["ürün"].Clear();
                Products();
            }
            else
            {
                MessageBox.Show("Barkod numarası girilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from ürün where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", connection);
            cmd.ExecuteNonQuery();

            set.Tables["ürün"].Clear();
            connection.Close();
            Products();
            MessageBox.Show("Ürün Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barkodnoquerytxt_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from ürün where barkodno like '%" + barkodnoquerytxt.Text + "%'", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            yazarcomboBox.Items.Clear();
            yazarcomboBox.Text = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from kitapbilgi where marka='" + comboBox2.SelectedItem + "'", connection); //kategoriye göre marka seçimi yapma
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yazarcomboBox.Items.Add(reader["yazar_adı"].ToString());
            }
            connection.Close();
        }

        private void yazarquerytxt_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from ürün where yazar_adı like '%" + yazarquerytxt.Text + "%'", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
