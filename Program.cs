using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sizeofA = new string[5]{
                                        "Small",
                                        "Medium",
                                        "Large",
                                        "Super",
                                        "Mega" };


            Console.WriteLine("Size are {0}", sizeofA.Length.ToString());
           
            Airport[] listofAirports = new Airport[5];
            Airport[] listofAirports_sort = new Airport[5];

            listofAirports[0] = new Airport("PARIS", "+ 33", sizeofA[2]);
            listofAirports[1] = new Airport("DOMODEDOVO", "+007", sizeofA[1]);
            listofAirports[2] = new Airport("ZVARTNOC", "+374", sizeofA[0]);
            listofAirports[3] = new Airport("NEW YORK", "+1", sizeofA[4]);
            listofAirports[4] = new Airport("MUNICH", "+49", sizeofA[3]);

            Console.WriteLine("This is unsorted Airport list:");
            for (int i = 0; i < listofAirports.Length; i++)
            {
                Console.WriteLine("SortAirport name- {0}, country code- {1} , size-{2}", listofAirports[i].Name.ToString(), listofAirports[i].CountryCode.ToString(), listofAirports[i].Size.ToString());
            }
            
            Console.WriteLine("This is sorted Airport list:");

            foreach (string str in sizeofA)
            {
                for (int i = 0; i < listofAirports.Length; i++)

                    if (str == listofAirports[i].Size)
                    {
                        listofAirports_sort[i] = listofAirports[i];
                        Console.WriteLine("SortAirport name- {0}, country code- {1} , size-{2}", listofAirports_sort[i].Name.ToString(), listofAirports_sort[i].CountryCode.ToString(), listofAirports_sort[i].Size.ToString());
                    }

            }
            Console.ReadLine();
        }
    }
}

