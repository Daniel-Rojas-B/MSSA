using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4
{
    public enum CoffeeType
    {
        Macchiato,
        Capuccino,
        Latte
    }
    public enum CoffeeSize
    {
        Small,
        Medium,
        Large
    }
    public enum Strength
    {
        Single,
        Double,
        Triple
    }
    public enum Roast
    {
        Light, 
        Medium, 
        Dark
    }
    public enum Milk
    {
        Whole, 
        Almond,
        Oat
    }
    public abstract class Beverage
    {
        public CoffeeSize Size { get; set; }
        public Milk Milk { get; set; }

        public Beverage(CoffeeSize size, Milk milk)
        {
            Size = size;
            Milk = milk;
        }
    }
    public class Coffee : Beverage
    {
        public CoffeeType Type { get; set; }
        public Strength Strength { get; set; }
        public Roast Roast { get; set; }

        public Coffee(CoffeeSize size, Milk milk, CoffeeType type, Strength strength, Roast roast) : base( size, milk)
        {
            Type = type;
            Strength = strength;
            Roast = roast;
        }
    }
}
