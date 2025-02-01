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
    public enum BeverageSize
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
        public BeverageSize BeverageSize { get; set; }
        public Milk Milk { get; set; }
        
    }
    internal class Coffee : Beverage
    {
        public CoffeeType CoffeeType { get; set; }
        
        public Strength Strength { get; set; }
        
        public Roast Roast { get; set; }

        
    }
}
