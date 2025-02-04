using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo
{
    class StudentGPAComparer: IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.GPA.CompareTo(y.GPA);
        }
    }

    internal class Student:IComparable<Student>
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public int age { get; set; }

        //names 
        public int CompareTo(Student? other)
        {
            int val=String.Compare(this.Name,other.Name, StringComparison.OrdinalIgnoreCase);
            return val;
        }
    }
}
