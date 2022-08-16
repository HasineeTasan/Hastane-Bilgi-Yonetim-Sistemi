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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        static string conString = ("Data Source=DESKTOP-J309SSN\\SQLEXPRESS;Initial Catalog=hastane_programı;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(conString);
      
        DataRow dr;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            DoktorGetir();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form16 frm = new Form16();
            dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            frm.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select k.kayit_id 'KAYIT NO',h.hasta_id 'HASTA NO' ,h.hasta_tc 'KİMLİK NO',h.hasta_ad 'AD',h.hasta_soyad 'SOYAD' from kayit k left outer join hastalar h on k.hasta_id = h.hasta_id where k.doktor_id = @doktor_id"
; 
            int doktor_id = Int32.Parse(comboBox1.SelectedValue.ToString());
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@doktor_id", doktor_id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();








        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public static DataGridViewRow SelectedRow { get; set; }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Özellik'te Seçili Satırı Ayarlayın.
                SelectedRow = dataGridView1.Rows[e.RowIndex];

                // Diğer Formu açın.
                Form16 form = new Form16();
                form.Show();
                //this.Hide();
            }
        }
    }
}
