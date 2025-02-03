namespace Mod4GenericsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * List
             * Q
             * Stack
             * Dictionary
             * SortedDictionary
            */

            Stack<int> intstack = new Stack<int>(); // LIFO
            
            Queue<string> customerQ = new Queue<string>(); //FIFO

            Dictionary<string, string> Recipes = new Dictionary<string, string>();
            Recipes.Add("Clear soup", "1. Boil broth ...");
            Recipes.Add("Fried chicken", "1. Boil water");

            foreach(var key in Recipes.Keys)
            {
                Console.WriteLine(key + "-" + Recipes[key]);
            }
            Recipes.Remove("Clear soup");

            // Dictionary<string, Person> phonebook = new Dictionary<string,Person>();
            // if(phoneBook.containskey("deepali"))
            //       Console.WriteLine("person alredy exists")
            // else phoneBook.add("deepali", new person() {name="deepelai", lastname="as", homephone=232323});

            // search using the contains method. 
        }
    }
}
