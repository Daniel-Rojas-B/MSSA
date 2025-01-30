using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9filedemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo(@"C:\");
            Console.WriteLine($"Drive name: {drive.Name}, drive size:{drive.TotalSize}, free space: {drive.TotalFreeSpace}");
            DirectoryInfo info = new DirectoryInfo(@"C:\Users");
            DirectoryInfo[] directories = info.GetDirectories();
            foreach (DirectoryInfo d in directories)
            {
                Console.WriteLine(d.Name + " " + d.CreationTime);
            }
            FileInfo[] fileInfos = info.GetFiles();
                foreach (FileInfo file in fileInfos)
                {
                Console.WriteLine(file.Name + " " + file.CreationTime);
                }
            
            Console.ReadKey();
        }
    }
}
