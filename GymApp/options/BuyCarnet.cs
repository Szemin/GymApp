using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.options
{ 
     class BuyCarnet
    {
        public BuyCarnet(int basicCarnet, int regularCarnet, int premiumCarnet)
        {
            BasicCarnet = basicCarnet;
            RegularCarnet = regularCarnet;
            PremiumCarnet = premiumCarnet;
        }
        public int BasicCarnet { get; set; }
        public int RegularCarnet { get; set; }
        public int PremiumCarnet { get; set; }

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
