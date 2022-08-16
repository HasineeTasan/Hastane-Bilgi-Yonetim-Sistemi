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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
       
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");

        private void Form10_Load(object sender, EventArgs e)
        {

            //TOPLAM DOKTOR SAYISI
            baglan.Open();
            SqlCommand tps = new SqlCommand("SELECT COUNT (*) FROM doktor", baglan);
            SqlDataReader tps_dr = tps.ExecuteReader();
            while (tps_dr.Read())
            {
                label8.Text = tps_dr[0].ToString();
            }
            baglan.Close();

            //ERKEK DOKTOR SAYISI
            baglan.Open();
            SqlCommand eps = new SqlCommand("SELECT COUNT (*) FROM doktor WHERE cinsiyet = 1", baglan);
            SqlDataReader eps_dr = eps.ExecuteReader();
            while (eps_dr.Read()) 
            {
                label9.Text = eps_dr[0].ToString();
            }
            baglan.Close();

            //Kadin DOKTOR Sayısını buluyorum.
            baglan.Open();
            SqlCommand kps = new SqlCommand("SELECT COUNT (*) FROM doktor WHERE cinsiyet = 0", baglan);
            SqlDataReader kps_dr = kps.ExecuteReader();
            while(kps_dr.Read())
            {
                label10.Text = kps_dr[0].ToString();
            }
            baglan.Close();

         

            //MAAŞ TOPLAMI
            baglan.Open();
            SqlCommand mt_komut = new SqlCommand("SELECT SUM(Maas) FROM doktor", baglan);
            SqlDataReader mt_dr = mt_komut.ExecuteReader();
            while (mt_dr.Read())
            {
                label11.Text=mt_dr [0].ToString();
            }
            baglan.Close();

            //MAAS ORTALAMASI
            baglan.Open();
            SqlCommand mo = new SqlCommand("SELECT AVG(Maas) FROM doktor", baglan);
            SqlDataReader mo_dr = mo.ExecuteReader();
            while (mo_dr.Read())
            {
                label12.Text = mo_dr[0].ToString();
            }
            baglan.Close();

            //KAÇ FARKLI ÜNVANDA DOKTOR VAR
            baglan.Open();
            SqlCommand füp = new SqlCommand("SELECT COUNT (DISTINCT(Unvan)) FROM doktor",baglan);
            SqlDataReader füp_dr = füp.ExecuteReader();
            while (füp_dr.Read())
            {
                label13.Text = füp_dr[0].ToString();
            }
            baglan.Close();

            //KAÇ FARKLI ŞEHİRDE DOKTOR VAR
            baglan.Open();
            SqlCommand kfsp = new SqlCommand("SELECT COUNT (DISTINCT(Sehir)) FROM doktor", baglan);
            SqlDataReader kfsp_dr = kfsp.ExecuteReader();
            while (kfsp_dr.Read())
            {
                label14.Text = kfsp_dr[0].ToString();
            }
            baglan.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Close();
        }
    }
}
