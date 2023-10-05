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
    public partial class SatisList : Form
    {
        public SatisList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        DataSet data = new DataSet();

        private void satisislem()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from satis", connection);
            adapter.Fill(data, "satis");
            dataGridView1.DataSource = data.Tables["satis"]; 

            connection.Close();
        }

        private void SatisList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stok_takibiDataSet.satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satisTableAdapter.Fill(this.stok_takibiDataSet.satis);
            satisislem(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.WriteXml(@"C:\Users\Lenovo\source\repos\KitabeviProje\KitabeviProje\satis.xml");
            MessageBox.Show("Veriler Eklendi!","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
