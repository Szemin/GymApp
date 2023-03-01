using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class ActionMenu
    {
        public static void MenuOfAction()
        {
        start:
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Wellcome.PersonalTrainers(); //lista trenerów do wyboru
                    break;
                case 2:
                    break;
                case 3:
                    ClientInfo client = new ClientInfo(); //konstruktor
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}
