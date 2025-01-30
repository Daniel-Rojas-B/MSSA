using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal class Instructor : Person
    {
        public double Salary  { get; set; }
        public override void FollowSchedule()
        {
            Console.WriteLine("I teach from 8 to 4 PST");
        }
        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("I teach and grade students");            
        }
    }

    // multilevel inheritance
    class ParttimeInstructor : Instructor
    {
        public override void FollowSchedule()
        {
            Console.WriteLine("I conduct labs from 2 to 4 PST");
        }
        public override void DoWork()
        {            
            Console.WriteLine("I check lab work");
        }
    }
}
