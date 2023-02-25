using GymApp;
using GymApp.Trainers;

class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();


        ClientInfo client = new ClientInfo(); //konstruktor
        //client.Data = Console.ReadLine();
        //Console.WriteLine($"client to {client.Data}");  //sprawdzanie czy dobrze pobrało dane 
        //UserData userData = new(); //obiekt 
        UserData.UserProfile(); // wyświetla karte profilu klubowicza

        ChrisBumstead chrisBumstead = new();
        //chrisBumstead.Name = "Chris Bumstead";
        //chrisBumstead.Ocupation = "Canada";
        //chrisBumstead.MrOlimpiaWins = 4;
        //chrisBumstead.Message = "Lift that up baby";
        chrisBumstead.TrainerData();


        Console.ReadKey();
    }
}