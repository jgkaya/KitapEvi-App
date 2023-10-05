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
    public partial class Marka : Form
    {
        public Marka()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");

        private void Marka_Load(object sender, EventArgs e)
        {
            kategori();
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
        private void newproductbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into markabilgi(kategori,marka) values('" + comboBox1.Text +"','"+textBox8.Text+"')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            comboBox1.Text = "";
            textBox8.Text = "";
            MessageBox.Show("Marka başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
