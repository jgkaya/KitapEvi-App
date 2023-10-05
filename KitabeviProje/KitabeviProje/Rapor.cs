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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stok_takibi;Integrated Security=True");
        private void Rapor_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select sum(miktari) from ürün",connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            stocklbl.Text = table.Rows[0][0].ToString();
            SqlDataAdapter adapter1 = new SqlDataAdapter("select count(id) from müşteri", connection);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            customerlbl.Text = table1.Rows[0][0].ToString();
            connection.Close();
        }

        private void stocklbl_Click(object sender, EventArgs e)
        {

        }

        private void musterietiket_Click(object sender, EventArgs e)
        {

        }
    }
}
