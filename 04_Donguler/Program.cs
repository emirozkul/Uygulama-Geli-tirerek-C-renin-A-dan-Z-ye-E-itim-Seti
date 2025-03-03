﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Donguler
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

            TrafikLambasi form1 = new TrafikLambasi();
            form1.Show();

            Timer_Ile_Digital_Saat form2 = new Timer_Ile_Digital_Saat();
            form2.Show();

            Progress_Bar form3 = new Progress_Bar();
            form3.Show();

            Pasta_Surecleri form4 = new Pasta_Surecleri();
            Application.Run(new Pasta_Surecleri());
        }
    }
}
