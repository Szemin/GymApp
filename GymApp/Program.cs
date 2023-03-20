using GymApp;
using GymApp.options;


    class Program
    {
        static void Main()
        {
            Wellcome.WellcomeCard(); //powitalna karta
            Console.WriteLine("press button :");
            Console.ReadLine();       
            ListOfActions.ActionList();  //lista wyboru akcji 
            ActionMenu.MenuOfAction();   //menu wyboru akcji            
            UserData.UserProfile(); // wyświetla karte profilu klubowicza

           
            Console.ReadKey();
        }
    }