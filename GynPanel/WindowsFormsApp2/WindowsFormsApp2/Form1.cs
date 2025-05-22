using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From dbo.Giris_tbl Where Kul_adi=@p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!!");
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From dbo.Admin_tbl Where Kul_adi=@p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!!");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
