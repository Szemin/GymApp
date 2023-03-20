using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymApp.options;

    internal class ClientInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
    public ClientInfo()
    {
        Console.WriteLine("Insert your First name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Insert your Last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Insert your Country of origin");
        string country = Console.ReadLine();
        Console.WriteLine("Insert your phone number");
        int phoneNumber = int.Parse(Console.ReadLine());
    }  
    public ClientInfo (string firstName, string lastName, string country, int phoneNumber)
    { 
        FirstName = firstName;
        LastName = lastName;
        Country = country;
        PhoneNumber = phoneNumber;
    }
        public static void Client()
        {
              ClientInfo client = new();  
        }
}
        
        //public void SayHi()
        //{
        //    Console.WriteLine($"Hello {FirstName} {LastName}");  //wita użytkownika 
        //}

    

