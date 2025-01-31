namespace Mod3Indexerdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            FoodMenu weekendMenu = new FoodMenu(new List<string> { "Sunday sandwich","Saturday pizza","Steak"});

            for (int i = 0; i < weekendMenu.Count; i++)
            {
                Console.WriteLine(weekendMenu[i]); // get this
            }
            Console.WriteLine("Add a new food item");
            weekendMenu[weekendMenu.Count] = Console.ReadLine();
            Console.WriteLine("Updated menu:");
            for (int i = 0;i < weekendMenu.Count; i++)
            {
                Console.WriteLine(weekendMenu[i]); // get this
            }
            Console.ReadKey();
        }
    }
}
