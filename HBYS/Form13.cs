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
    public partial class Form13 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into hastalar (hasta_tc,hasta_ad,hasta_soyad,hasta_dogumy,hasta_dogumt,hasta_anneadi,hasta_babaadi,hasta_cinsiyet,hasta_il,hasta_ilce,hasta_tel,hasta_adres,kayit_türü) values (@hasta_tc,@hasta_ad,@hasta_soyad,@hasta_dogumy,@hasta_dogumt,@hasta_anneadi,@hasta_babaadi,@hasta_cinsiyet,@hasta_il,@hasta_ilce,@hasta_tel,@hasta_adres,@kayit_türü)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@hasta_tc", textBox2.Text);
                komut.Parameters.AddWithValue("@hasta_ad", textBox13.Text);
                komut.Parameters.AddWithValue("@hasta_soyad", textBox1.Text);
                komut.Parameters.AddWithValue("@hasta_dogumy", textBox3.Text);
                komut.Parameters.AddWithValue("@hasta_dogumt", textBox4.Text);
                komut.Parameters.AddWithValue("@hasta_anneadi", textBox12.Text);
                komut.Parameters.AddWithValue("@hasta_babaadi", textBox5.Text);
                komut.Parameters.AddWithValue("@hasta_cinsiyet", textBox6.Text);
                komut.Parameters.AddWithValue("@hasta_il", textBox7.Text);
                komut.Parameters.AddWithValue("@hasta_ilce", textBox8.Text);
                komut.Parameters.AddWithValue("@hasta_tel", textBox9.Text);
                komut.Parameters.AddWithValue("@hasta_adres", textBox10.Text);
                komut.Parameters.AddWithValue("@kayit_türü", textBox11.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }

            catch (Exception hata)

            {
                MessageBox.Show("Hata Meydana Geldi." + hata.Message);
            }
        }
    }
}
