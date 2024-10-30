using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_KararYapilari
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Ogrenci_Not_Hesaplama form1 = new Ogrenci_Not_Hesaplama();
            form1.Show();

            Indirim_tutari_hesaplama form2 = new Indirim_tutari_hesaplama();
            form2.Show();

            Secilen_operatore_gore_islem_yapma form3 = new Secilen_operatore_gore_islem_yapma();
            form3.Show();

            Bilgi_Yarismasi form4 = new Bilgi_Yarismasi();
            Application.Run(new Bilgi_Yarismasi());
            
        }
    }
}
