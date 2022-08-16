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
    public partial class Form7 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        DataRow dr;


        public Form7()
        {
            InitializeComponent();
            ilGetir();
            illGetir();
        }
        static string conString = "Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        void ilGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from il", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "İl Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "sehiradi";
            comboBox2.SelectedIndex = -1;
            comboBox2.DataSource = dt;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != null)
            {
                int id = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                ilceGetir(id);
            }
        }
        public void ilceGetir(int id)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ilceler where il_id=@id", baglanti);
            komut.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "İlçe Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox3.ValueMember = "id";
            comboBox3.DisplayMember = "ilceadi";
            comboBox3.DataSource = dt;

        }

        SqlConnection baglanti1;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_programıDataSet2.il' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilTableAdapter.Fill(this.hastane_programıDataSet2.il);

            baglanti1 = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
            baglanti1.Open();
            da = new SqlDataAdapter("select * from personeller", baglanti1);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "personeller");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti1.Close();
            



            Doktorlar();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void illGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from il", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "İl Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox5.ValueMember = "id";
            comboBox5.DisplayMember = "sehiradi";
            comboBox5.SelectedIndex = -1;
            comboBox5.DataSource = dt;

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue.ToString() != null)
            {
                int id = Convert.ToInt32(comboBox5.SelectedValue.ToString());
                illceGetir(id);
            }
        }
        public void illceGetir(int id)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ilceler where il_id=@id", baglanti);
            komut.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dr = dt.NewRow();

            dr.ItemArray = new object[] { 0, "İlçe Seçiniz" };
            dt.Rows.InsertAt(dr, 0);

            comboBox6.ValueMember = "id";
            comboBox6.DisplayMember = "ilceadi";
            comboBox6.DataSource = dt;

        }



        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into personeller(tc,kurum,ad,soyad,anneadi,babaadi,dogumyeri,dogumtarihi,cinsiyet,medenihali,ünvani,kayit_il,kayit_ilce,adres,iil,iilce,evtel,istel,ceptel) values (@tc,@kurum,@ad,@soyad,@anneadi,@babaadi,@dogumyeri,@dogumtarihi,@cinsiyet,@medenihali,@ünvani,@kayit_il,@kayit_ilce,@adres,@iil,@iilce,@evtel,@istel,@ceptel)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@tc", textBox1.Text);
                komut.Parameters.AddWithValue("@kurum", comboBox1.Text);
                komut.Parameters.AddWithValue("@ad", textBox7.Text);
                komut.Parameters.AddWithValue("@soyad", textBox6.Text);
                komut.Parameters.AddWithValue("@anneadi", textBox5.Text);
                komut.Parameters.AddWithValue("@babaadi", textBox4.Text);
                komut.Parameters.AddWithValue("@dogumyeri", textBox2.Text);
                komut.Parameters.AddWithValue("@dogumtarihi", textBox9.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboBox4.Text);
                komut.Parameters.AddWithValue("@medenihali", textBox8.Text);
                komut.Parameters.AddWithValue("@ünvani", textBox13.Text);
                komut.Parameters.AddWithValue("@kayit_il", comboBox2.Text);
                komut.Parameters.AddWithValue("@kayit_ilce", comboBox3.Text);
                komut.Parameters.AddWithValue("@adres", textBox3.Text);
                komut.Parameters.AddWithValue("@iil", comboBox5.Text);
                komut.Parameters.AddWithValue("@iilce", comboBox6.Text);
                komut.Parameters.AddWithValue("@evtel", textBox10.Text);
                komut.Parameters.AddWithValue("@istel", textBox11.Text);
                komut.Parameters.AddWithValue("@ceptel", textBox12.Text);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt Eklendi");
            }

            catch (Exception hata)

            {
                MessageBox.Show("Hata Meydana Geldi." + hata.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update(ds, "personeller");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        { }

        SqlConnection baglandik;
        
        SqlDataAdapter das;

        void Doktorlar() {
        baglandik = new SqlConnection("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
            baglandik.Open();
            das = new SqlDataAdapter("select * from personeller ", baglandik);
            DataTable tablo  = new DataTable();
            das.Fill(tablo );
            dataGridView1.DataSource = tablo;
            baglandik.Close();


        }
        

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            comboBox6.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
    }

