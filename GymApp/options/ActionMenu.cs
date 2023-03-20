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
            int? number = 0;
            while(number != null)
            { 
            number = int.Parse(Console.ReadLine()) ;    //try catch zrobić

                switch (number)
                {
                    case 1:
                        Wellcome.PersonalTrainers(); //lista trenerów do wyboru
                        break;
                    case 2:
                        CarnetList.ReadFiles();
                        break;
                    case 3:
                        Console.WriteLine("Do you want to create new member card?  yes/no");
                        string yesNo = "";
                        while (yesNo != "yes" || yesNo != "Yes" || yesNo != "no" || yesNo != "No")
                        {
                            yesNo = Console.ReadLine();
                            Console.WriteLine("incorrect value");
                            if (yesNo is "yes" or "Yes")
                            {
                                ClientInfo client = new ClientInfo(); //konstruktor
                                break;
                            }
                            else if (yesNo is "no" or "No")
                            {
                                ListOfActions.ActionList();
                                MenuOfAction();
                            }
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("You choose wrong option");
                        MenuOfAction();
                        break;
                }   
                    
            }
        }
    }
}
