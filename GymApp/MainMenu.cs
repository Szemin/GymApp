using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class Wellcome
    {
        static List<string> Trainers = new List<string>
        {
            "1.Ronnie Coleman",
            "2.Jay Cutler",
            "3.Arnold Schwarzenegger",
            "4.Chris Bumstead"
        };
        public static void WellcomeCardDesign()
        {
            Console.WriteLine("                            ");
            Console.WriteLine("^    -----Wellcome-----    ^");
            Console.WriteLine("------------ TO ------------");
            Console.WriteLine("-----     ZYZZ GYM     -----");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
        public static void PersonalTrainers()
        {
          foreach (string trainers in Trainers)
            {
                Console.WriteLine(trainers);
            }
        }
    }
}
