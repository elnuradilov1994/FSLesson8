using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLesson8.Extentions
{
    public static class Extentions
    {
        public static int MySum(this int num1,int num2)
        {
            int result = 1;
            for(int i = num2; i >= 1; i--)
            {
                result *= num1;
            }
            return result;
        }
    }
}
