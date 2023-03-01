using GymApp;
using GymApp.Trainers;

class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign(); //powitalna karta
        Console.WriteLine("press button :");
        Console.ReadLine();
        Start:
        ListOfActions.ActionList();
        ActionMenu.MenuOfAction();
        goto Start;

        UserData.UserProfile(); // wyświetla karte profilu klubowicza

        //client.Data = Console.ReadLine();
        //Console.WriteLine($"client to {client.Data}");  //sprawdzanie czy dobrze pobrało dane 

       // ChrisBumstead chrisBumstead = new(); //obiekt klasy ChrisBumstead => do przeniesienia inna klasa     
       // chrisBumstead.TrainerData(); //info odnośnie trenera


        Console.ReadKey();
    }
}