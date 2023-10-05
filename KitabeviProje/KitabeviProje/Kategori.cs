using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitabeviProje
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        bool durum;
        private void kategoricontrol()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from kategoribilgi",connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox7.Text==reader["kategori"].ToString() || textBox7.Text=="")
                {
                    durum = false;
                }
            }
            connection.Close();
        }
        private void Kategori_Load(object sender, EventArgs e)
        {

        }

        private void stockproductbutton_Click(object sender, EventArgs e)
        {
            kategoricontrol();
            if (durum==true)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into kategoribilgi(kategori) values('" + textBox7.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox7.Text = "";
        }
    }
}
