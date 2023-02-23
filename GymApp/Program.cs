using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();


        ClientInfo client = new ClientInfo(); //konstruktor

        client.Dupa = Console.ReadLine();

        Console.WriteLine($"client to {client.Dupa}");



        UserData userData = new(); //obiekt

        UserData.UserProfile();
       


        Console.ReadKey();
    }
}