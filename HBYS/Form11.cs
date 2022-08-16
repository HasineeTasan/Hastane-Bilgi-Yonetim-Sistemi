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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglanıyoruz = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");


        private void Form11_Load(object sender, EventArgs e)
        {

            //BİRİNİCİ GRAFİK ŞEHİRLER

            baglanıyoruz.Open();
            SqlCommand grafik1 = new SqlCommand("SELECT Sehir, COUNT(*)FROM doktor GROUP BY Sehir",baglanıyoruz);
            SqlDataReader grafik1_dr = grafik1.ExecuteReader();
            while (grafik1_dr.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(grafik1_dr[0], grafik1_dr[1]);
            }
            baglanıyoruz.Close();

            //İKİNCİ GRAFİK ÜNVANLAR

            baglanıyoruz.Open();
            SqlCommand grafik2 = new SqlCommand("SELECT Unvan,COUNT(*)FROM doktor GROUP BY Unvan", baglanıyoruz);
            SqlDataReader grafik2_dr = grafik2.ExecuteReader();
            while (grafik2_dr.Read())
            {
                chart2.Series["Unvan"].Points.AddXY(grafik2_dr[0], grafik2_dr[1]);
            }
            baglanıyoruz.Close();

            //ÜÇÜNCÜ GRAFİK ÜNVANLARA GÖRE MAAŞ ORTALAMASI SUNAN
            baglanıyoruz.Open();
            SqlCommand grafik3 = new SqlCommand("SELECT Unvan,AVG(Maas) FROM doktor GROUP BY Unvan", baglanıyoruz);
            SqlDataReader grafik3_dr = grafik3.ExecuteReader(); 
            while (grafik3_dr.Read())
            {
                chart3.Series["UnvanMaasOrtalamasi"].Points.AddXY(grafik3_dr[0], grafik3_dr[1]);
            }
            baglanıyoruz.Close();

            //DÖRDÜNCÜ GRAFİK CİNSİYETLER
            baglanıyoruz.Open();
            SqlCommand grafik4 = new SqlCommand("SELECT Cinsiyet,COUNT(*)FROM doktor GROUP BY Cinsiyet",baglanıyoruz);
            SqlDataReader grafik4_dr = grafik4.ExecuteReader();
            while (grafik4_dr.Read())
            {
                chart4.Series["Cinsiyet"].Points.AddXY(grafik4_dr[0], grafik4_dr[1]);
            }
            baglanıyoruz.Close();





        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();

        }
    }
}
