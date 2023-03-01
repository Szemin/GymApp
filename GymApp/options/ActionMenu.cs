using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.options
{
    public class ActionMenu
    {
        public static void MenuOfAction()
        {
        start:
            int number = int.Parse(Console.ReadLine()) ;    //try catch zrobić

            switch (number)
            {
                case 1:
                    Wellcome.PersonalTrainers(); //lista trenerów do wyboru
                    break;
                case 2:
                    break;
                case 3:
                back:
                    Console.WriteLine("Do you want to create new member card?  yes/no");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "no" || yesNo == "No")
                    {
                        goto start;
                    }
                    else if (yesNo == "yes" || yesNo == "Yes")
                    {
                        ClientInfo client = new ClientInfo(); //konstruktor
                    }
                    else
                    {
                        goto back;
                    }
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("You choose wrong option");
                    goto start;
                   
                    
            }
        }
    }
}
