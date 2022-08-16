using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProgramı
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
       
        


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
            this.Hide();
        }
    }
}
