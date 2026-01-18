using FSLesson8.Extentions;
using FSLesson8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 5;
            //Console.WriteLine(num1.MySum(4));

            //int a = 10;
            //int b = 5;

            //Console.WriteLine(a.Multiply(b));

            UserCounter user1 = new UserCounter();


            UserCounter.RegisterUser();
            UserCounter.RegisterUser();
            UserCounter.RegisterUser();
            UserCounter.RegisterUser();
            UserCounter.RegisterUser();

            UserCounter.ShowCount();
        }
    }
}
    

