using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class Wellcome
    {
        public static void WellcomeCardDesign()
        {
            Console.WriteLine("                            ");
            Console.WriteLine("^    -----Wellcome-----    ^");
            Console.WriteLine("------------ TO ------------");
            Console.WriteLine("-----     ZYZZ GYM     -----");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
        public static void GymProfileCard()
        {
            Console.WriteLine("                            ");
            Console.WriteLine("^    -----Gym Member-----    ^");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"-----First Name:  {ClientInfo.GetFirstName()}     -----");
            Console.WriteLine($"-----Last Name:   {ClientInfo.GetLastName()}     -----");
            Console.WriteLine($"-----Date of birth:                             ");
            Console.WriteLine();
        }
    }
}
