using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();
        ClientInfo client = new ClientInfo();
        client.vClientInfo();
        client.SayHi();
        UserData userData = new UserData();
        
        Console.ReadKey();
    }
}