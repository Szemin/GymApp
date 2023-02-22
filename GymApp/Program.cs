using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();
        ClientInfo client = new ClientInfo();
        client.SetFirstNameLastName();
        //client.GetFirstName();
        //client.GetLastName();
        client.SayHi();
        Console.ReadKey();
    }
}