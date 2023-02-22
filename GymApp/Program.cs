using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();
        ClientInfo client = new ClientInfo();
        client.SayHi();
        UserData userData = new();
        userData.PhoneNumber =int.Parse(Console.ReadLine());
        Console.WriteLine(userData.PhoneNumber);
       // UserData userData = new UserData();
        
        Console.ReadKey();
    }
}