using GymApp;
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
       




        Console.ReadKey();
    }
}