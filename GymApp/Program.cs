using GymApp;
using GymApp.Trainers;

class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign(); //powitalna karta

        ClientInfo client = new ClientInfo(); //konstruktor

        //tu teraz wyświetlić listę z opcjami
        ListOfActions.test();
        //client.Data = Console.ReadLine();
        //Console.WriteLine($"client to {client.Data}");  //sprawdzanie czy dobrze pobrało dane 
        //UserData userData = new(); //obiekt 
        UserData.UserProfile(); // wyświetla karte profilu klubowicza
        Wellcome.PersonalTrainers();//lista trenerów do wyboru

        ChrisBumstead chrisBumstead = new(); //obiekt klasy ChrisBumstead => do przeniesienia inna klasa     
        chrisBumstead.TrainerData(); //info odnośnie trenera


        Console.ReadKey();
    }
}