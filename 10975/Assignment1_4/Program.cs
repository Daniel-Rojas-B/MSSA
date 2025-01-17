using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            
            Point p1 = new Point();
            Point p2 = new Point();
            Console.WriteLine("Type x coordinate for P1");
            p1.Xvalue = int.Parse(Console.ReadLine());
            Console.WriteLine("Type y coordinate for P1");
            p1.Yvalue = int.Parse(Console.ReadLine());
            Console.WriteLine("Type x coordinate for P2");
            p2.Xvalue = int.Parse(Console.ReadLine());
            Console.WriteLine("Type y coordinate for P2");
            p2.Yvalue = int.Parse(Console.ReadLine());
            Comparison(p1, p2);

            Console.ReadLine();

            Console.WriteLine(" ---- Problem 2 ----");
            Student s1 = new Student(1, "Daniel", "Rojas", 'A');
            Console.WriteLine("id: " + s1.StudentId + " Name: " + s1.StudentFname + " Last name: " + s1.StudentLname + " Grade: " + s1.StudentGrade);

            Console.ReadKey();

        }
        public static void Comparison(Point p1, Point p2)
        {
            if (p1.Xvalue < p2.Xvalue)
            {
                Console.WriteLine("P2 is to the right of P1");
            }
            else
            {
                Console.WriteLine("P2 is to the left of P1");
            }
        }

    }
}
