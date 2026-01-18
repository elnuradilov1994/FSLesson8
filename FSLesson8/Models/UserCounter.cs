using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLesson8.Models
{
    internal class UserCounter
    {

       
    public static int TotalUsers { get; set; } = 0;

       
        public static void RegisterUser()
        {
            TotalUsers++;
        }

     
        public static void ShowCount()
        {
            Console.WriteLine("Umumi istifadeci sayi: " + TotalUsers);
        }
    }
}
