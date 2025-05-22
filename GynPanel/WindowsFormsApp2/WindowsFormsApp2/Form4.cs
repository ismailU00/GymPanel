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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Uye_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From dbo.Uye_tbl ", baglanti);
            DataTable dtb1 = new DataTable();
            komut.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
