using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.CodeDom;


namespace Mod9Filedemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\\Files\\";
            Console.WriteLine("Exploring file IO operations");
            Console.WriteLine("Enter a file name with .txt extension");
            string filename = path + Console.ReadLine(); //pcad16.txt
            StreamWriter writer = null; // it is pointing to nowhere

            try
            {
                if(!File.Exists(filename))
                {
                    writer = File.CreateText(filename);
                    writer.WriteLine($"New file created at {DateTime.Now}");
                    Console.WriteLine("File created");
                }
                else
                {
                    File.AppendAllText(filename,$"new line appended at {DateTime.Now}");
                    Console.WriteLine("File appended");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }

            Console.WriteLine("Reading contents from file ...");
            // using block is used to create a scope for that object and is automatically disposed off when the closing bracket is reached 
            using(StreamReader reader = new StreamReader(filename))
            {
                string line;
                while((line=reader.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }
    }
}
