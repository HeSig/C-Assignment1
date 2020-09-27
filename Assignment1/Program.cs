using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1.Buildings;
using Assignment1.ListManager;

namespace Assignment1
{
    //Author: Henrik Sigeman and My Adolfsson.
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            ListManager<Estate> listManager = new ListManager<Estate>();
            Estate testEstate1 = new Estate(1, 2, 3, "Storgatan", );

            //int id, int sqrft, int rent, Address address, Legal legal, string image

            List<Estate> testEstateList = new List<Estate>();


        }
    }
}
