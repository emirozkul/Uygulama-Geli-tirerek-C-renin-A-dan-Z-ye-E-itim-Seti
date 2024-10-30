using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using NAudio.Wave;

namespace _3_KararYapilari
{
    public partial class Bilgi_Yarismasi : Form
    {
        private WaveOutEvent waveOut;
        private SoundPlayer player;

        public Bilgi_Yarismasi()
        {
            InitializeComponent();
            this.Load += Bilgi_Yarismasi_Load;
            waveOut = new WaveOutEvent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = 5;
            player = new SoundPlayer();
        }

        private void Bilgi_Yarismasi_Load(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "_3_KararYapilari.acilisMuzigi.wav";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                player.Stream = stream;
                player.Play();
            }
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            waveOut.Volume = trackBar1.Value / 100f;
        }

        private void buttonBaslama_Click(object sender, EventArgs e)
        {
            player.Stop();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "_3_KararYapilari.baslangıcMuzigi.wav";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                player.Stream = stream;
                player.Play();
            }

            YarısmaEkrani yeniForm = new YarısmaEkrani();
            yeniForm.Show(); 
            this.Hide(); 

        }
    }
}
