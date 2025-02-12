namespace Mod2Recursion1
{
    internal class Program
    {
        static void PrintDirectoriesinDirectory(string path, int depth)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (string d in directories)
            {
                Console.WriteLine(d);
                if (depth > 0)
                {
                    PrintDirectoriesinDirectory(d, depth-1); // recursive call
                }
            }
            
        }
        static void Main(string[] args)
        {
            const string path = @"C:\Users\danie\Documents\MSSA\";


            PrintDirectoriesinDirectory (path, 1);
            Console.ReadKey();
            
        }
    }
}
