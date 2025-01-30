using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Daniel";
            student.LastName = "Rojas";
            student.Address = "123 abc";
            student.Age = 34;
            student.GPA = 4;

            Console.WriteLine($"{student.FirstName} living in {student.Address} has a GPA of {student.GPA}");

            student.Communicate();
            student.DoWork();
            student.FollowSchedule();

            Instructor instructor = new Instructor();
            instructor.FirstName = "Felipe";
            instructor.Salary = 5000;
            Console.WriteLine($"{instructor.FirstName} has a salary of {instructor.Salary}");
            instructor.FollowSchedule();
            instructor.DoWork();

            ParttimeInstructor parttimeInstructor = new ParttimeInstructor();
            parttimeInstructor.FirstName = "Danny";
            parttimeInstructor.Salary = 2500;
            Console.WriteLine($"{parttimeInstructor.FirstName} has a salary of {parttimeInstructor.Salary}");
            parttimeInstructor.FollowSchedule();
            parttimeInstructor.DoWork();

            Console.ReadKey();
        }
    }
}
