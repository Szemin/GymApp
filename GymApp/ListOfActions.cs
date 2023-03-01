using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    //public enum Action
    //{
    //    ShowTrainerList,
    //    ShowTrainingPlans,
    //    CreateProfileCard,
    //    BuyMembership
    //}
    public class ListOfActions
    {
       private static List<string> ShowActionList()
        {
            List<string> actions = new List<string>
        {
            "1.ShowTrainerList",
            "2.ShowTrainingPlans",
            "3.CreateProfileCard",
            "4.BuyMembership"
        };
            return actions;
        }
       public static void test()
        {
            List<string> actions = ShowActionList();
            foreach (var list in actions)
            {
                Console.WriteLine(list);
            }
        }
    }

}
