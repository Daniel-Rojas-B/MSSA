using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal class Student: Person
    {
        public float GPA { get; set; }
        // abstract override (compulsion)
        public override void FollowSchedule()
        {
            Console.WriteLine("I am in virtual classroom from 8-4 PST");
        }
        // virtual override (choice)
        public override void DoWork()
        {
            // base.DoWork(); flexibility 
            Console.WriteLine("I do c# assignments");
        }
    }
}
