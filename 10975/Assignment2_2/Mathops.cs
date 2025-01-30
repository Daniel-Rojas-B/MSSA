using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    internal static class Mathops
    {
        public static int add(int num1,  int num2)
        {
            return num1 + num2;
        }
        public static decimal add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }
        public static float multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
