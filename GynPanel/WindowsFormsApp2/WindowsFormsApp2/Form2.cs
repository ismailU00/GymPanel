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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6D39EC0\\SQLEXPRESS;Initial Catalog=Login_db;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into dbo.Giris_tbl (Kul_adi,Sifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Kayıt Olundu!!");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }
    }
}
