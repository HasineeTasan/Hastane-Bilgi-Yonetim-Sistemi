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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        static string conString = ("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString);

      
        private void Form8_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

       
        void KayitGetir()
        {
           
            baglanti.Open();
            string kayit = "SELECT Ad 'AD',Soyad 'SOYAD',Unvan 'ÜNVAN' FROM doktor";
           SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * FROM doktor WHERE Ad=@Ad";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Ad",textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
