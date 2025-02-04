using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Generics2
{
    // T: place holder for data type
    internal class Swap<T>
    {
        public void SwapData(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
