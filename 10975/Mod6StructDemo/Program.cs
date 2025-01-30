using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Test;

//namespace Test
//{
//    public struct Student
//    {

//    }
//}

namespace Mod6StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PostalAddress postal = new PostalAddress();

            PostalAddress myaddress = new PostalAddress();
            Console.WriteLine($"{myaddress.GetHashCode()}, {myaddress.GetType()}");
            myaddress.HouseNumber = 27;
            myaddress.StreetName = "Tideway Lane";
            myaddress.City = "Ontario";
            myaddress.ZipCode = 91761;
            Console.WriteLine($"{myaddress.GetHashCode()}, {myaddress.GetType()}");
            
            Console.WriteLine($"The address is {myaddress.HouseNumber}, {myaddress.StreetName}, {myaddress.City}, {myaddress.ZipCode}");
            //Student student1 = new Student();
            Console.WriteLine($"{myaddress.GetHashCode()}, {myaddress.GetType()}");

            PostalAddress yourAddress = new PostalAddress(27, "lincoln st", "Malibu", "CA", 91768);

            Console.ReadKey();
        }
    }
}
