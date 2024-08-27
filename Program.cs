using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__deskstop__application
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
            Application.Run(new Splash());
            Application.Run(new Form1());
            //Application.Run(new Categories());
            //Application.Run(new ProductForm());
            //Application.Run(new Seller());
            //Application.Run(new Selling());


        }
    }
}












