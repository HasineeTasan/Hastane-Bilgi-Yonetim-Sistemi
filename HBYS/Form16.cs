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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);



        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_programıDataSet14.TaniKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.taniKayitTableAdapter.Fill(this.hastane_programıDataSet14.TaniKayit);
            // TODO: Bu kod satırı 'hastane_programıDataSet11.tanilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tanilarTableAdapter.Fill(this.hastane_programıDataSet11.tanilar);
            // TODO: Bu kod satırı 'hastane_programıDataSet10.tanılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
 
            textBox1.Text=Form15.SelectedRow.Cells[0].Value.ToString();
            label2.Text = Form15.SelectedRow.Cells[0].Value.ToString();
            label3.Text = Form15.SelectedRow.Cells[1].Value.ToString();
            label4.Text = Form15.SelectedRow.Cells[2].Value.ToString();
            label5.Text = Form15.SelectedRow.Cells[3].Value.ToString();
            label6.Text = Form15.SelectedRow.Cells[4].Value.ToString();
            TanıGetir();
            HastanınTanısı();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Width = 70;
            dataGridView2.Columns[2].Width = 450;
            dataGridView2.Columns[1].HeaderText = "KODU";
            dataGridView2.Columns[2].HeaderText = "TANI";


        }
        void TanıGetir()
        {
            baglanti=new SqlConnection ("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select tani_id,tani_kodu,tani_adi from tanilar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
        }
     void HastanınTanısı() {

            baglanti.Open();
            string kayit = "select tk.tani_kayit_id,tani_kodu'TANI KODU',tani_adi'TANI ADI' from TaniKayit tk left outer join tanilar t on tk.tani_id = t.tani_id where kayit_id=@kayit_id"
;
            int kayit_id = Int32.Parse(label2.Text);
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@kayit_id",kayit_id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            //Form15 frm = new Form15();
            //frm.Show();
            //this.Hide();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    
       
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into TaniKayit(tani_id,kayit_id) values (@tani_id,@kayit_id)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@tani_id", textBox2.Text);
                komut.Parameters.AddWithValue("@kayit_id", textBox1.Text);




                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Tanı Eklendi");
                HastanınTanısı();



            }

            catch (Exception hata)

            {
                MessageBox.Show("Hata Meydana Geldi." + hata.Message);
            } 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastanınTanısı();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "Delete TaniKayit where tani_kayit_id = @tani_kayit_id";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                int tani_kayit_id = Int32.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@tani_kayit_id", tani_kayit_id);




                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Tanı Silindi");
                HastanınTanısı();



            }

            catch (Exception hata)

            {
                MessageBox.Show("Hata Meydana Geldi." + hata.Message);
            }
        }
    }
    }
    
   
 

