using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();


        ClientInfo client = new ClientInfo(); //konstruktor
        
        UserData userData = new(); //obiekt

        UserData.UserProfile();
        client.SayHi();


        Console.ReadKey();
    }
}