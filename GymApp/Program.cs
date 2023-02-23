using GymApp;
class Program
{
    static void Main()
    {
        Wellcome.WellcomeCardDesign();
        ClientInfo client = new ClientInfo();
        client.SayHi();
  
        //userData.PhoneNumber =int.Parse(Console.ReadLine());
        //Console.WriteLine(userData.PhoneNumber);
        UserData.UserPhone();

        //Console.WriteLine($" to imie {ClientInfo.GetFirstName()}");

        Console.ReadKey();
    }
}