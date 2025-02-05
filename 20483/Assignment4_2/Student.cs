using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2
{
    class StudentGPAComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.GPA.CompareTo(y.GPA);
        }
    }
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
    }
}
