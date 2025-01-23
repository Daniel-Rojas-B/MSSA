using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    internal static class OutputFormatter
    {
        // Overloading:  is written the same method within the same class but with different number of parameters or different type of parameters
        // overloading is within the same class
        // overriding is over clases (inheritance)
        // static clasess cannot be instantiated and derived from
        private static void Test()
        {

        }
        public static void DisplayName(string firstName) 
        {
            Console.WriteLine("Welcome {0}, enjoy the course!",firstName); // interpolation can be used too.
        }
        public static void DisplayName(string firstName, string lastName)
        {
            Console.WriteLine($"Welcome {firstName} {lastName}, enjoy the course!");
        }
    }
    class C : OutputFormatter
    {

    }
}
