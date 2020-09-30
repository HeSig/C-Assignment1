﻿using System;
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



            //int id, int sqrft, int rent, Address address, Legal legal, string image
            //string _street, int _zip, string _city, Countries _country
            //path till fil = C:\Users\adolf\Source\Repos\C-Assignment1\Assignment1\DataFiles\

            Address address = new Address("Storgatan 22", 23443, "Malmö", Countries.Sverige);
            Estate testEstate = new Estate(1, 3, 45, address, Estate.Legal.Ownership, "House.jpg");
            String path = "C:\'Users\'adolf\'Source\'Repos\'C-Assignment1\'Assignment1\'DataFiles\'";

            ListManager<Estate> testListManager = new ListManager<Estate>();
            bool serializeBoolResult = testListManager.BinarySerialize(path);
            Console.WriteLine("serialize binary: " + serializeBoolResult); //true

            bool deserializeBoolResult = testListManager.BinaryDeSerialize(path);
            Console.WriteLine("deserialize binary: " + deserializeBoolResult); //false

            bool xmlExportBoolResult = testListManager.XMLSerialize(path);
            Console.WriteLine("XML export: " + xmlExportBoolResult); //true



        }
    }
}
