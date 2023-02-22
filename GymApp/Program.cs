using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();
        ClientInfo client = new ClientInfo();
        //client.SetFirstNameLastName();
        client.SayHi();
        Console.ReadKey();
    }
}