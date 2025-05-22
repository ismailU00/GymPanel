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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Uye_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into dbo.uye_tbl (kul_ad, kul_soyad, kul_cinsiyet, kul_yas, kul_kilo, kul_boy, kul_uye_baslangic, kul_uye_bitis) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.Parameters.AddWithValue("@p7", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p8", maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Kayıt Olundu!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
