using GymApp;
using GymApp.Trainers;

class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign(); //powitalna karta
        Console.WriteLine("press button :");
        Console.ReadLine();

        ListOfActions.ActionList();

        ActionMenu.MenuOfAction();

        UserData.UserProfile(); // wyświetla karte profilu klubowicza

        //client.Data = Console.ReadLine();
        //Console.WriteLine($"client to {client.Data}");  //sprawdzanie czy dobrze pobrało dane 
        //UserData userData = new(); //obiekt 
        //Wellcome.PersonalTrainers();//lista trenerów do wyboru

        ChrisBumstead chrisBumstead = new(); //obiekt klasy ChrisBumstead => do przeniesienia inna klasa     
        chrisBumstead.TrainerData(); //info odnośnie trenera


        Console.ReadKey();
    }
}