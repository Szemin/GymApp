using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymApp;

     class CarnetList
    {
        public static void ReadFiles()          //wyświetla karnety
        {
            var basic = File.ReadAllText(@"D:\karnety\BASIC.txt");
            var regular = File.ReadAllText(@"D:\karnety\REGULAR.txt");
            var premium = File.ReadAllText(@"D:\karnety\PREMIUM.txt");

           StringBuilder sb = new StringBuilder();  
            sb.AppendLine(basic);
            sb.AppendLine();
            sb.AppendLine(regular);
            sb.AppendLine();
            sb.AppendLine(premium);
            sb.AppendLine();
            var result = sb.ToString();
            Console.WriteLine(result);

        }
    }

