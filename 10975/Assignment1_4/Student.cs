using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    public class Student
    {
        
        public Student(int studentid, string studentfname, string studentlname, char studentgrade)
        {
                StudentId = studentid;
                StudentFname = studentfname;
                StudentLname = studentlname;
                StudentGrade = studentgrade;
        }
        public int StudentId { get; set; }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public char StudentGrade { get; set; }
    }
}
