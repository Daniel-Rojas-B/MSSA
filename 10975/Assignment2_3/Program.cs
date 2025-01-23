using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.CodeDom;

namespace Assignment2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\\Users\\danie\\Documents\\MSSA\\10975\\";
            Console.WriteLine("Saving basic details");
            Console.WriteLine("Enter a file name with .txt extension");
            string completePath = path + Console.ReadLine();
            StreamWriter writer = null;

            try
            {
                if (!File.Exists(completePath))
                {
                    writer = File.CreateText(completePath);
                    writer.WriteLine("Name: Daniel");
                    writer.WriteLine("Age: 20");
                    writer.WriteLine("Address: 123 abc");
                    writer.WriteLine($"New file created at {DateTime.Now}");
                    Console.WriteLine("File created");
                }
                else
                {
                    File.AppendAllText(completePath, $"new line appended at {DateTime.Now}");
                    Console.WriteLine("File appended");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            Console.WriteLine("Reading contents from file ...");
            
            using (StreamReader reader = new StreamReader(completePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }
    }
}
