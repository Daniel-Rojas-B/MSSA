using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    enum MonthAdm
    {
        January,
        February,
        March, 
        April,
        May, 
        June, 
        July, 
        August,
        September,
        October, 
        November, 
        December
    }
    internal class Student
    {
        public int StudentId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public MonthAdm MonthAdm { get; set; }
        public char Grade { get; set; }
    }
}
