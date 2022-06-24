using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism2
{
    internal static class Program
    {

       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cember cember = new Cember();
            cember.yaricap = 3;
            Console.WriteLine("cember alani: " + cember.alan());

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisakenar = 3;
            dikdortgen.uzunkenar = 5;
            Console.WriteLine("dikdörtgen alan: "+dikdortgen.alan());



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
