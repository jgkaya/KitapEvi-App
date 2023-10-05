using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitabeviProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        DataSet data = new DataSet();
        private void sepetislem()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from sepet",connection);
            adapter.Fill(data, "sepet");
            dataGridView1.DataSource = data.Tables["sepet"]; //müşteri hakkındaki bilgiler listede yazmasın
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok_takibiDataSet.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter.Fill(this.stok_takibiDataSet.sepet);
            sepetislem();
        }
        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodtxt.Text == "")
            {
                foreach (Control item in product.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != miktartxt)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from ürün where barkodno like'" + barkodtxt.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yazartxt.Text = reader["yazar_adı"].ToString();
                uruntxt.Text = reader["urunadi"].ToString();
                miktartxt.Text = reader["miktari"].ToString();
                satistxt.Text = reader["satisfiyat"].ToString();
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barkodcontrol();
            if (durum==true)
            {
                connection.Open();
                
                SqlCommand cmd = new SqlCommand("insert into sepet(id,adsoyad,telefon,adres,mail,barkodno,urunadi,miktari,satisfiyat,toplamfiyat,tarih) " +
                    "values(@id,@adsoyad,@telefon,@adres,@mail,@barkodno,@urunadi,@miktari,@satisfiyat,@toplamfiyat,@tarih) ", connection);
                cmd.Parameters.AddWithValue("@id", idtxt.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtname.Text);
                cmd.Parameters.AddWithValue("@telefon", txtnumber.Text);
                cmd.Parameters.AddWithValue("@adres", txtaddress.Text);
                cmd.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
                cmd.Parameters.AddWithValue("@urunadi", uruntxt.Text);
                cmd.Parameters.AddWithValue("@miktari", int.Parse(miktartxt.Text));
                cmd.Parameters.AddWithValue("@satisfiyat", double.Parse(satistxt.Text));
                cmd.Parameters.AddWithValue("@toplamfiyat", double.Parse(toplamtxt.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update sepet miktari=miktari+'" + int.Parse(miktartxt.Text) + "'where barkodno='"+barkodtxt.Text+"'", connection);
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("update sepet toplamfiyat=miktari*satisfiyat where barkodno='"+barkodtxt.Text+"'", connection);
                command2.ExecuteNonQuery();
                
                connection.Close();
            }
            
            miktartxt.Text = "1";
            data.Tables["sepet"].Clear();
            sepetislem();
            calculate();
            foreach (Control item in product.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != miktartxt)
                        {
                            item.Text = "";
                        }
                    }

                }
           
        }

        private void miktartxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamtxt.Text = (double.Parse(miktartxt.Text) * double.Parse(satistxt.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void satistxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamtxt.Text = (double.Parse(miktartxt.Text) * double.Parse(satistxt.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Multiply)
            {
                miktartxt.Text = barkodtxt.Text.Substring(barkodtxt.Text.Length - 1);
                barkodtxt.Text = "";
            }
        }
        bool durum;
        private void barkodcontrol()
        {
            durum = true;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from sepet",connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (barkodtxt.Text==reader["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            connection.Close();
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Tables["sepet"].Clear();
            
            sepetislem();
            
            calculate();
        }

        private void satisiptalbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from sepet ", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            
            MessageBox.Show("Satış iptal!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            data.Tables["sepet"].Clear();
            sepetislem();
            calculate();
        }
        

        private void calculate()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select sum(toplamfiyat) from sepet",connection);
                finallbl.Text = cmd.ExecuteScalar()+" TL";
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void satisButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into satis(id,adsoyad,telefon,adres,mail,barkodno,urunadi,miktari,satisfiyat,toplamfiyat,tarih) " +
                    "values(@id,@adsoyad,@telefon,@adres,@mail,@barkodno,@urunadi,@miktari,@satisfiyat,@toplamfiyat,@tarih) ", connection);
                cmd.Parameters.AddWithValue("@id", idtxt.Text);
                cmd.Parameters.AddWithValue("@adsoyad", txtname.Text);
                cmd.Parameters.AddWithValue("@telefon", txtnumber.Text);
                cmd.Parameters.AddWithValue("@adres", txtaddress.Text);
                cmd.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                cmd.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                cmd.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                cmd.Parameters.AddWithValue("@satisfiyat", double.Parse(dataGridView1.Rows[i].Cells["satisfiyat"].Value.ToString()));
                cmd.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("update ürün set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                
            }
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("delete from sepet ", connection);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Satış tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Tables["sepet"].Clear();
            sepetislem();
            calculate();
        }

        private void eklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAdd add = new CustomerAdd();
            add.ShowDialog();
        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList customer = new CustomerList();
            customer.ShowDialog();
        }

        private void eklemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductAdd product = new ProductAdd();
            product.ShowDialog();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.ShowDialog();
        }

        private void markaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marka marka = new Marka();
            marka.ShowDialog();
        }

        private void listelemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductList list = new ProductList();
            list.ShowDialog();
        }

        private void satışListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisList satis = new SatisList();
            satis.ShowDialog();
        }

        private void customer_Enter(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                txtname.Text = "";
                txtnumber.Text = "";
                txtaddress.Text = "";
                txtmail.Text = "";
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from müşteri where id like'" + idtxt.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtname.Text = reader["adsoyad"].ToString();
                txtnumber.Text = reader["telefon"].ToString();
                txtaddress.Text = reader["adres"].ToString();
                txtmail.Text = reader["mail"].ToString();
            }
            connection.Close();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.ShowDialog();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
