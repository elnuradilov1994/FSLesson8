using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLesson8.Extentions
{
    public static class MathHelper
    {
        public static int Add (this int a, int b) 
        {
            return a + b;
        }
        public static int Subtract(this int a, int b)
        {
            return a - b;
        }
        public static int Multiply(this int a, int b)
        {
            return a * b;
        }
        public static int Divide(this int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("0-a bolme emeliyyati yoxdur");
            }
            return a / b;
        }
    }
}
