using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form4 : Form
    {

        private bool cancelFlag = false;
        private bool cancelFlag2 = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            cancelFlag = false;
            cancelFlag2 = true;

            if(cancelFlag2) 
            { 
                for (int i = 0; i < 100; i++)
                {
                    if (cancelFlag)
                    {
                        break;
                    }

                    label5.Text = "Giriş Yapılıyor.";
                    await Task.Delay(500);
                    label5.Text = "Giriş Yapılıyor..";
                    await Task.Delay(500);
                    label5.Text = "Giriş Yapılıyor...";
                    await Task.Delay(500);

                }
            }
        }

        

        private async void button2_Click(object sender, EventArgs e)
        {
            cancelFlag = true;
            cancelFlag2 = false;

            if(cancelFlag) { 
                for (int i = 0; i < 100; i++)
                {
                    if (cancelFlag2)
                    {
                        break;
                    }

                    label5.Text = "Şifre Değiştiriliyor.";
                    await Task.Delay(500);
                    label5.Text = "Şifre Değiştiriliyor..";
                    await Task.Delay(500);
                    label5.Text = "Şifre Değiştiriliyor...";
                    await Task.Delay(500);
                }
            }
        }
        
    }
}
