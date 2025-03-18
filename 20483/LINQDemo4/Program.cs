namespace LINQDemo4
{
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>
            {
                new Car() { VIN = "ABC123", Make = "Audi", Model = "Q5", Year = 2020, Price = 66000 },
                new Car() { VIN = "ABC124", Make = "BMW", Model = "X5", Year = 2021, Price = 76000 },
                new Car() { VIN = "ABC125", Make = "BMW", Model = "X7", Year = 2022, Price = 56000 },
                new Car() { VIN = "ABC126", Make = "Lexus", Model = "TX", Year = 2023, Price = 46000 },
                new Car() { VIN = "ABC127", Make = "Lamborghini", Model = "Urus", Year = 2024, Price = 36000 }
            };

            var bmws = from c in list
                         where c.Make == "BMW"
                         select new { c.Model, c.Year };
            Console.WriteLine("bmws:");
            foreach (var c in bmws)
            {
                Console.WriteLine($"{c.Model} and year {c.Year}");
            }

            var cars2020=(from c in list
                          where c.Year==2020
                          select c).Count();

            var audis2020 = list.FindAll(c => c.Make == "Audi" && c.Year == 2020);
            Console.WriteLine("Audis");
            foreach (var c in audis2020)
            {
                Console.WriteLine($"{c.VIN} -- {c.Make} -- {c.Model} -- {c.Year}");
            }
            
            Console.ReadKey();
        }
    }
}
