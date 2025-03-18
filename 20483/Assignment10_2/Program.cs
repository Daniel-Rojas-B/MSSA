namespace Assignment10_2
{
    internal class Program
    {
        class Employee
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            
        }
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>
            {
                2, -1, 3, -3, 10, -200
            };
            List<int> list2 = new List<int>
            {
                55,200,740,76,230,482,95
            };

            var numbers = from n in list
                       where n > 0
                       select n;
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine("numbers:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" ---- Problem 2 ---- ");
            List<Employee> employeeList = new List<Employee>
            {
                new Employee() { Age = 10, Name = "Daniel", Salary = 6000 },
                new Employee() { Age = 31, Name = "Daniel", Salary = 4000 },
                new Employee() { Age = 32, Name = "Daniel", Salary = 7000 }
            };

            var employees = from e in employeeList
                            where e.Salary > 5000 && e.Age <30
                            select new { e.Name, e.Age, e.Salary };
            Console.WriteLine("Employees who have salary more than $5000 and age < 30");
            foreach (var e in employees)
            {
                Console.WriteLine($"Name: {e.Name} Salary: {e.Salary} Age:{e.Age}");
            }

            Console.WriteLine(" ---- Problem 3 ---- ");
            List<string> citiesList = new List<string>
            {
                "AROMEM","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
            };
            Console.WriteLine(" Input first letter ");
            string firstLetter = Console.ReadLine().ToUpper();
            Console.WriteLine(" Input last letter ");
            string lastLetter = Console.ReadLine().ToUpper();

            var city = from c in citiesList
                       where (c.StartsWith(firstLetter) && c.EndsWith(lastLetter))
                       select c;

            if (city.Any())
                Console.WriteLine(string.Join(", ", city));
            else
                Console.WriteLine("No matching cities found.");

            var numbers2 = from n in list2
                          where n > 80
                          select n;
            Console.WriteLine(" ---- Problem 4 ---- ");
            Console.WriteLine("numbers > 80:");
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
