using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
     class CarnetList
    {
        public static void ReadFiles()          //wyświetla karnety
        {
            var basic = File.ReadAllText(@"D:\karnety\BASIC.txt");
            var regular = File.ReadAllText(@"D:\karnety\REGULAR.txt");
            var premium = File.ReadAllText(@"D:\karnety\PREMIUM.txt");

            Console.WriteLine(basic);
            Console.WriteLine();
            Console.WriteLine(regular);
            Console.WriteLine();
            Console.WriteLine(premium);

        }
    }
}
