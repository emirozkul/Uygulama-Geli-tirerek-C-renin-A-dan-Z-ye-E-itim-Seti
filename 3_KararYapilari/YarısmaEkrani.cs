using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_KararYapilari
{
    public partial class YarısmaEkrani : Form
    {
        public YarısmaEkrani()
        {
            InitializeComponent();
            buttonSonraki.Text = "BAŞLA";
            pictureBox1.Visible = false;
        }

        int soruNo = 0, dogruSayisi = 0, yanlisSayisi = 0;

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            if (buttonB.Text == label4.Text)
            {
                dogruSayisi++;
                labelDogru.Text = dogruSayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlis.Text = yanlisSayisi.ToString();
                pictureBox3.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            if (buttonC.Text == label4.Text)
            {
                dogruSayisi++;
                labelDogru.Text = dogruSayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlis.Text = yanlisSayisi.ToString();
                pictureBox3.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            if (buttonD.Text == label4.Text)
            {
                dogruSayisi++;
                labelDogru.Text = dogruSayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlis.Text = yanlisSayisi.ToString();
                pictureBox3.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonSonraki.Enabled = true;

            if (buttonA.Text==label4.Text)
            {
                dogruSayisi++;
                labelDogru.Text = dogruSayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisSayisi++;
                labelYanlis.Text = yanlisSayisi.ToString();
                pictureBox3.Visible = true;
            }
        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonSonraki.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            buttonSonraki.Text = "SONRAKİ SORU";
            soruNo++;
            labelSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL hangi üniversitede lisans eğitimini tamamlamıştır?";
               
                buttonA.Text = "ODTÜ";
                buttonB.Text = "İTÜ";
                buttonC.Text = "KTÜ";
                buttonD.Text = "Boğaziçi";

                label4.Text = "İTÜ";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL'ın oğlunun ismi nedir?";

                buttonA.Text = "Bora";
                buttonB.Text = "Ata";
                buttonC.Text = "Emir";
                buttonD.Text = "Emre";

                label4.Text = "Bora";
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL kaç yaşındadır?";

                buttonA.Text = "52";
                buttonB.Text = "60";
                buttonC.Text = "50";
                buttonD.Text = "55";

                label4.Text = "50";
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL hangi bölümde öğretim üyesidir?";

                buttonA.Text = "İnşaat Mühendisliği";               
                buttonB.Text = "Elektrik Elektronik Mühendisliği";
                buttonC.Text = "Makine Mühendisliği";
                buttonD.Text = "Bilgisayar Mühendisliği";

                label4.Text = "Bilgisayar Mühendisliği";
            }

            if (soruNo == 5)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL şimdiye kadar hangi dersi vermemiştir?";

                buttonA.Text = "SHELL PROGRAMMING";
                buttonB.Text = "INTRODUCTION TO PROGRAMMING";
                buttonC.Text = "CALCULUS I";
                buttonD.Text = "SAYISAL TASARIM";

                label4.Text = "CALCULUS I";
            }

            if (soruNo == 6)
            {
                richTextBox1.Text = "Doç. Dr. Deniz DAL hangi dillerde ders anlatmaktadır?";

                buttonA.Text = "Türkçe-İngilizce";
                buttonB.Text = "İngilizce-Karadenizce";
                buttonC.Text = "Almanca-Arapça";
                buttonD.Text = "Fransızca-Almanca";

                label4.Text = "Türkçe-İngilizce";

                buttonSonraki.Text = "SONUÇLAR";
            }

            if (soruNo == 7)
            {
                if (yanlisSayisi>=dogruSayisi)
                {
                    MessageBox.Show("MEZUN OLAMADIN!");
                }
                else
                {
                    MessageBox.Show("TEBRİKLER MEZUN OLDUN!" +"\n"+ "Doğru Sayısı: " + dogruSayisi + "\n" + "Yanlış Sayısı: " + yanlisSayisi);
    
                }

                this.Close();

            }
        }
    }
}
