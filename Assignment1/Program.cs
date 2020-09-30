using System;
using System.Collections.Generic;
using System.IO;
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
            Application.Run(new Form1());
            /*

            //tests for the binarySerialize, binaryDeserialize and XMLSerialize in ListManager

            //setting up data
            Address address1 = new Address("Storgatan 22", 23443, "Malmö", Countries.Sverige);
            Address address2 = new Address("Storgatan 23", 23443, "Malmö", Countries.Sverige);
            Address address3 = new Address("Storgatan 24", 23443, "Malmö", Countries.Sverige);

            Estate testEstate1 = new Estate(1, 3, 45, address1, Estate.Legal.Ownership, "House.jpg");
            Estate testEstate2 = new Estate(2, 3, 45, address2, Estate.Legal.Ownership, "House.jpg");
            Estate testEstate3 = new Estate(3, 3, 45, address3, Estate.Legal.Ownership, "House.jpg");

            String path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\DataFiles\\Tester";

            ListManager<Estate> testListManager = new ListManager<Estate>();
            testListManager.Add(testEstate1);
            testListManager.Add(testEstate2);
            testListManager.Add(testEstate3); 

            //testing binarySerialize in ListManager
            bool serializeBoolResult = testListManager.BinarySerialize(path);
            Console.WriteLine("serialize binary: " + serializeBoolResult);

            testListManager.DeleteAll();

            //testing binaryDeserialize in ListManager
            bool deserializeBoolResult = testListManager.BinaryDeSerialize(path);
            Console.WriteLine("deserialize binary: " + deserializeBoolResult);
           
            for (int i = 0; i < testListManager.Count; i++)
            {
                Console.WriteLine("ID: " + testListManager.GetAt(i).Id + " Address : " + testListManager.GetAt(i).Address.Street);
            }

            //testing XMLSerialize in ListManager
            bool xmlExportBoolResult = testListManager.XMLSerialize(path);
            Console.WriteLine("XML export: " + xmlExportBoolResult);
            */
        }
    }
}
