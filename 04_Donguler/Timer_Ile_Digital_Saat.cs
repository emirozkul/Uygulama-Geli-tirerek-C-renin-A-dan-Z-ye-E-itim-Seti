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
    public partial class Timer_Ile_Digital_Saat : Form
    {
        int saat = 0, dakika = 0, saniye = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Timer_Ile_Digital_Saat()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = saniye.ToString("D2");
            label3.Text = dakika.ToString("D2");
            label4.Text = saat.ToString("D2");

            if (saniye == 59)
            {
                saniye = 0;
                dakika++;
            }

            if (dakika == 59)
            {
                dakika = 0;
                saat++;
            }

            if (saat == 23)
            {
                saat = 0;
            }
        }
    }
}
