﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymApp.options;

    public class ActionMenu 
    {
        public static void MenuOfAction()
        {
            int? number = 0;
            while(number != null)
            { 
            number = int.Parse(Console.ReadLine());    //try catch zrobić

                switch (number)
                {
                    case 1:
                        Wellcome.ShowTList();
                        Wellcome.ShowData();                //lista trenerów do wyboru
                        break;
                    case 2:
                        CarnetList.ReadFiles();
                        break;
                    case 3:
                        Console.WriteLine("Do you want to create new member card?  yes/no");
                        string yesNo = "";
                        while (yesNo != "yes" || yesNo != "Yes" || yesNo != "no" || yesNo != "No") //xD
                        {
                            yesNo = Console.ReadLine();
                            
                            if (yesNo is "yes" or "Yes")
                            {
                            ClientInfo.Client(); //konstruktor
                                break;
                            }
                            else if (yesNo is "no" or "No")
                            {
                                ListOfActions.ActionList();
                                MenuOfAction();
                            }
                            else { Console.WriteLine("incorrect value"); }
                        }
                        break;
                    case 4:
                    //ClientInfo.Client();
                        break;
                    default:
                        Console.WriteLine("You choose wrong option");
                        MenuOfAction();
                        break;
                }   
                    
            }
        }
    }

