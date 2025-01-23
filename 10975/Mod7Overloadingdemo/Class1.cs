using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    internal class A
    {
        public int Id {  get; set; }
        public virtual void Method1()
        {
            Console.WriteLine("In method1");
        }
    }
    class B : A
    {
        public string Name { get; set; }

        public void Method2()
        {

        }
        public override void Method1()

        {
            Console.WriteLine("In method1 from class B");
        }
    }
}
