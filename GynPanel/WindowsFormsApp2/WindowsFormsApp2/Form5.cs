using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Uye_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From dbo.Uye_tbl ", baglanti);
            DataTable dtb1 = new DataTable();
            komut.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Uye_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From dbo.uye_tbl Where kul_ad ='" + textBox1.Text+ "'", baglanti); ;
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayit silindi");

        }



        private void button3_Click(object sender, EventArgs e)
        {
          
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

     

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Uye_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update dbo.uye_tbl Set kul_ad=@p1,kul_soyad=@p2,kul_cinsiyet=@p3,kul_yas=@p4,kul_kilo=@p5,kul_boy=@p6,kul_uye_baslangic=@p7,kul_uye_bitis=@p8", baglanti);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            guncelle.Parameters.AddWithValue("@p5", textBox5.Text);
            guncelle.Parameters.AddWithValue("@p6", textBox6.Text);
            guncelle.Parameters.AddWithValue("@p7", maskedTextBox1.Text);
            guncelle.Parameters.AddWithValue("@p8", maskedTextBox2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
