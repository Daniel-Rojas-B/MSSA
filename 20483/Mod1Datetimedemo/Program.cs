using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Datetimedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Amy", "Alex", "Adam", "Zoe", "Frank" };
            //// LINQ: language integrated query expressions
            //// select name from table name  where ... sql
            //var names_A = from name in names
            //              where name.StartsWith("A");
            //              select name;

            //Console.WriteLine("Names starting with A");
            //foreach (var n in names_A)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();

            string[] names = { "Amy", "Alex", "Adam", "Zoe", "Frank" };
            // LINQ:Language integrated Query exprssions
            // select name from Tablename where...sql
            // 1. use of var
            var names_A = from name in names
                          where name.StartsWith("A")
                          select name;

            Console.WriteLine("Names starting with A");
            foreach (var n in names_A)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("It is " + DateTime.Now.ToLongDateString());
            Console.WriteLine("Enter your dob in yyyy/mm/dd");
            var dob = Convert.ToDateTime(Console.ReadLine());

            var age = CalculateAge(dob);
            Console.WriteLine($"You are {age} years old");
            var months = ((DateTime.Now.Year*12) + DateTime.Now.Month) - ((dob.Year*12) + dob.Month);
            float preciseAge = months / 12.0f;
            Console.WriteLine($"Precise age {preciseAge}");


            Console.ReadKey();
        }

        static int CalculateAge(DateTime dateDOB)
        {
            return DateTime.Now.Year - dateDOB.Year;
        }
    }
}
