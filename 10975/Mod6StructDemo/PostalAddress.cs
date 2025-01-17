using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6StructDemo
{
    public struct PostalAddress
    {
        public PostalAddress(int housenumber, string streetname, string city, string state, int zipcode)
        {
            HouseNumber = housenumber;
            StreetName = streetname;
            City = city;
            this.state = state;
            this.ZipCode = zipcode;
        }
        public PostalAddress(int housenumber)
        {
            HouseNumber = housenumber;
            StreetName = string.Empty;
            City = string.Empty;
            this.ZipCode = 0;
            this.state = string.Empty;
        }
        public int HouseNumber { get; set; } // two way property 
        public string StreetName { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        
        private string state;
        public string State
        {
            get {
                if (ZipCode == 111)
                    state = "NY";
                return state;
            }
        }
    }
}
