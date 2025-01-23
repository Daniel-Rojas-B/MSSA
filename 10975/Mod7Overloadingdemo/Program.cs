using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A();
            objA.Method1();
            B objB = new B();
            objB.Method1();
            A obj1 = new B(); // this is using the method to overrride the class A return. Cross reference. 
            // state of the object is that of the left hand side and in this case is gonna be from A. It can be invoke from child class provided it is overriden and crossreference is done. In this case from B. 
            obj1.Method1();

            // utility class typically holds functions together and may not need properties to hold data, make the functions as static
            OutputFormatter.DisplayName("Daniel");
            OutputFormatter.DisplayName("Felipe", "Rojas");

            
                   
            // B obj2 = new A();  not allowed , against polymorphism nature
            
            Service firstService = new Service();
            
            Console.ReadKey();
        }
    }
}
