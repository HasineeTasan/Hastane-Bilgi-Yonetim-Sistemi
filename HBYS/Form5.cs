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

namespace HastaneProgramı
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglandı = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglandı.Open();
            SqlCommand Giris = new SqlCommand("SELECT id FROM kullanicilar WHERE kullaniciAdi=@p1 and sifre=@p2", baglandı);
            Giris.Parameters.AddWithValue("@p1", textBox1.Text);
            Giris.Parameters.AddWithValue("@p2", textBox2.Text);

            SqlDataReader dr = Giris.ExecuteReader();
            if (dr.Read())
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış");
            }
            baglandı.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
