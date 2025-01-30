using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    public struct Point
    {
        public Point(int xvalue, int yvalue)
        {
            Xvalue = xvalue;
            Yvalue = yvalue;
        }
        public int Xvalue { get; set; }
        public int Yvalue { get; set; }
    }
}
