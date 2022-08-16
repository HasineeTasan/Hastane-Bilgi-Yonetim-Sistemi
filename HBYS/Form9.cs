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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglanıyoruz;
        SqlCommand komut;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder komutlar;
        DataRow dr;
        private object doktorTableAdapter;

        void PersonelGetir()
        {


            baglanıyoruz = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
            baglanıyoruz.Open();
            adapter = new SqlDataAdapter("select * from doktor", baglanıyoruz);
            komutlar = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "doktor");
            dataGridView1.DataSource = ds.Tables[0];
            baglanıyoruz.Close();

        }


        void illGetir()
        {
            baglanıyoruz.Open();
            SqlCommand komut = new SqlCommand("select * from il", baglanıyoruz);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanıyoruz.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "İl Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "sehiradi";
            comboBox1.SelectedIndex = -1;
            comboBox1.DataSource = dt;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_programıDataSet8.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorTableAdapter1.Fill(this.hastane_programıDataSet8.doktor);
            PersonelGetir();
            illGetir();
          
        
        
        
        }

        private void button1_Click(object sender, EventArgs e) // KAYDET BUTONU
        {
            try
            {
                baglanıyoruz.Open();
                SqlCommand kaydet = new SqlCommand("INSERT INTO doktor (Tc 'tc',Ad 'ad',Soyad 'soyad',DogumTarihi 'dogum tarihi',Cinsiyet 'cinsiyet',Sehir 'sehir',Tel 'telefon',Unvan 'ünvan',Maas 'maass') VALUES (@Tc,@Ad,@Soyad,@DogumTarihi,@Cinsiyet,@Şehir,@Tel,@Unvan,@Maas)", baglanıyoruz);
                kaydet.Parameters.AddWithValue("@Tc", textBox1.Text);
                kaydet.Parameters.AddWithValue("@Ad", textBox2.Text);
                kaydet.Parameters.AddWithValue("@Soyad", textBox3.Text);
                kaydet.Parameters.AddWithValue("@DogumTarihi", textBox4.Text);

                if (radioButton2.Checked)
                {
                    kaydet.Parameters.AddWithValue("@Cinsiyet", true);
                }
                if (radioButton1.Checked)
                {
                    kaydet.Parameters.AddWithValue("@Cinsiyet", false);
                }

                kaydet.Parameters.AddWithValue("@Şehir", comboBox1.Text);
                kaydet.Parameters.AddWithValue("@Tel", textBox6.Text);
                kaydet.Parameters.AddWithValue("@Unvan", textBox5.Text);
                kaydet.Parameters.AddWithValue("@Maas", textBox7.Text);

                kaydet.ExecuteNonQuery(); 
                baglanıyoruz.Close();
                MessageBox.Show("Kayıt eklenmiştir");
            


            }
            catch (Exception)
            {
                MessageBox.Show("Tüm ilgili alanlar doldurulmalıdır!");
            }
            Temizle();
            Listele();
                
                
                }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string cinsiyetDeger = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if (cinsiyetDeger == "True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            comboBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            textBox5.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }



        void Listele()
        {
            this.personellTableAdapter.Fill(this.hastane_programıDataSet6.personell);
        }


        private void button2_Click(object sender, EventArgs e) //LİSTELE BUTONU
        {
            this.doktorTableAdapter1.Fill(this.hastane_programıDataSet8.doktor);
        }


        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedItem = null;
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }
        private void button5_Click(object sender, EventArgs e)//TEMİZLE BUTONU
        {
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e) //GÜNCELLE BUTONU
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz öğeyi çift tıklayınız.");
            }
            else
            {
                baglanıyoruz.Open();

                SqlCommand guncelle = new SqlCommand("UPDATE doktor SET  Ad=@Ad, Soyad=@Soyad, DogumTarihi=@DogumTarihi, Cinsiyet=@Cinsiyet, Sehir=@p4,Tel=@Tel, Unvan=@Unvan, Maas=@Maas WHERE Tc=@Tc", baglanıyoruz);
                guncelle.Parameters.AddWithValue("@Tc", textBox1.Text);
                guncelle.Parameters.AddWithValue("@Ad", textBox2.Text);
                guncelle.Parameters.AddWithValue("Soyad",textBox3);
                guncelle.Parameters.AddWithValue("DogumTarihi",textBox4);
                if (radioButton2.Checked)
                {
                    guncelle.Parameters.AddWithValue("@Cinsiyet", true);
                }
                if (radioButton1.Checked)
                {
                    guncelle.Parameters.AddWithValue("@Cinsiyet", false);
                }


                guncelle.Parameters.AddWithValue("@Sehir",comboBox1.SelectedItem);
                guncelle.Parameters.AddWithValue("@Tel",textBox5.Text );
                guncelle.Parameters.AddWithValue("@Unvan",textBox6.Text);
                guncelle.Parameters.AddWithValue("@Maas",textBox7.Text);

                _ = guncelle.ExecuteNonQuery();
                baglanıyoruz.Close();
                MessageBox.Show("Güncelleme işlemi tamamlandı");


            }
            Listele();
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen listelenen öğeler içinde silmek istediğinizi çift tıklayınız!");
            }

            else
            {
                baglanıyoruz.Open();
                SqlCommand sil = new SqlCommand("DELETE FROM doktor WHERE TC=@Tc",baglanıyoruz );

                sil.Parameters.AddWithValue("@Tc",textBox1.Text);
                sil.ExecuteNonQuery();
                baglanıyoruz.Close();
                MessageBox.Show("Kayıt silinmiştir.");

            }
            Listele();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 frm= new Form10();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
