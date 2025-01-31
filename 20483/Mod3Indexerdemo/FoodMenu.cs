using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Indexerdemo
{
    
    internal class FoodMenu
    {
        private List<string> fooditems; //names are gonna be put here

        public FoodMenu(List<string> foods) // constructor, only string data can go in the list
        {
            this.fooditems = foods;
        }
        public int Count { get { return fooditems.Count; } } // 3

        public string this[int index] // 0, 1, 2
        {
            get
            {
                if (index < this.Count)
                {
                    return this.fooditems[index];
                }
                return string.Empty;
            }
            set
            {
                if (!this.fooditems.Contains(value))
                {
                    this.fooditems.Add(value);
                }
            }
        }
    }
}
