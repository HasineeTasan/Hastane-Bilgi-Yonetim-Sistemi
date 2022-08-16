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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
           //illGetir();
        }

      
        static string conString = ("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString);
        DataRow dr;



        private void Form14_Load(object sender, EventArgs e)
        {
            DoktorGetir();
            // TODO: Bu kod satırı 'hastane_programıDataSet7.hastalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hastalarTableAdapter.Fill(this.hastane_programıDataSet7.hastalar);
            //comboBox1.Items.Clear();

            /*baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT doktor_id,CONCAT (Ad, ' ',Soyad ) isim FROM doktor ", baglanti);
            sorgu.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu);
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["isim"].ToString());
            }
            baglanti.Close();*/


            //close the connection
            




        }
        void DoktorGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select doktor_id, concat (ad, ' ',soyad) isim from personeller", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 1, "Doktor Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "doktor_id";
            comboBox1.DisplayMember = "isim";
            //comboBox1.SelectedIndex = -1;
            comboBox1.DataSource = dt;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }




        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * FROM hastalar  where hasta_ad like '%' + @Ad +'%'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into kayit(hasta_id ,doktor_id ,kayit_tarih ) values (@hasta_id,@doktor_id,GETDATE())";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                int hasta_id = Int32.Parse(textBox2.Text);
                int doktor_id = Int32.Parse(comboBox1.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@hasta_id", hasta_id);
                komut.Parameters.AddWithValue("@doktor_id", doktor_id);
             

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            catch
            {
                MessageBox.Show("Kayıt Eklenemedi." );
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Hide();
        }
      

    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
