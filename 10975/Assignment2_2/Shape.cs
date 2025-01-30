using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    internal abstract class Shape
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string color { get; set; }

        // I use virtual method so I can change the functionality in the derived classes
        public virtual double calculateArea()
        {
            return 0;
        }
    }
    class Circle : Shape
    {
        public int Radius {  get; set; }

        public override double calculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Square : Shape
    {
        public int Side { get; set; }

        public override double calculateArea()
        {
            return Side * Side;
        }
    }
}
