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
       public static List<string> ShowActionList()
        {
           List<string> actions = new List<string>
        {
            "1.Show Trainer List",
            "2.Show Training Plans",
            "3.Create Profile Card",
            "4.Buy Membership"
        };
            return actions;
        }
       public static void ActionList()
        {
            List<string> actions = ShowActionList();
            foreach (var list in actions)
            {
                Console.WriteLine(list);
            }
        }
    }

}
