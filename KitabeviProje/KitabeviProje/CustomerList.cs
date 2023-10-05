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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void CustomerList_Load(object sender, EventArgs e)
        {
            Kayıt();
        }
        private void Kayıt()
        {
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from müşteri", connection);
            sqlData.Fill(dataSet, "müşteri");
            dataGridView1.DataSource = dataSet.Tables["müşteri"];
            connection.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtnumber.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtaddress.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,mail=@mail where id=@id", connection);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@adsoyad", txtname.Text);
            cmd.Parameters.AddWithValue("@telefon", txtnumber.Text);
            cmd.Parameters.AddWithValue("@adres", txtaddress.Text);
            cmd.Parameters.AddWithValue("@mail", txtmail.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            dataSet.Tables["müşteri"].Clear();
            Kayıt();
            MessageBox.Show("Müşteri kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from müşteri where id='"+dataGridView1.CurrentRow.Cells["id"].Value.ToString()+"'",connection);
            cmd.ExecuteNonQuery();
            
            
            connection.Close();
           dataSet.Tables["müşteri"].Clear();
            Kayıt();
            MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtquery_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from müşteri where id like '%"+txtquery.Text+"%'",connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
