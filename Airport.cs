using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    

    class Airport
    {
        public Airport()
        {

        }
        public Airport(string name, string countrycode,string size)
        {
            this.Name = name;
            this.CountryCode = countrycode;
            this.Size = size;
        }
        public  string Name { get; set; }
        public  string CountryCode { get; set; }
        public  string Size { get; set; }
    }
}
