using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Donguler
{
    public partial class Pasta_Surecleri : Form
    {
        public Pasta_Surecleri()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void Pasta_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            pictureBox1.Visible = false;

            if (progressBar1.Value == 100)
            {
                this.Hide();
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            progressBar1.Value += 5;

            if (progressBar1.Value>=0 && progressBar1.Value <=20 )
            {
                pictureBox2.Visible = true;
                button1.Text = "Alışveriş Yapılıyor";

            }

            if (progressBar1.Value >= 21 && progressBar1.Value <= 40)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                button1.Text = "Malzemeler Hazırlanıyor";
            }

            if (progressBar1.Value >= 41 && progressBar1.Value <= 60)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                button1.Text = "Karıştırılıyor";
            }

            if (progressBar1.Value >= 61 && progressBar1.Value <= 80)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                button1.Text = "Fırınlandı ve Pişiriliyor";
            }

            if (progressBar1.Value >= 81 && progressBar1.Value <= 99)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Text = "Son dokunuşlar yapılıyor";
            }
            if (progressBar1.Value == 100)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;               
                timer1.Stop();
                button1.Enabled = true;
                button1.Text = "AFİYET OLSUN!";
                MessageBox.Show("Pasta Hazır");              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            this.Hide();
        }
    }
}
