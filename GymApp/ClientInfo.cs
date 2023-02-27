using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class ClientInfo
    {
        private static string FirstName;
        
       // public string? Data { get; set; }  //test właściwości zakończony powodzeniem, działa identycznie jak konstruktor poniżej...

        private static string LastName;

        private static string CountryOfOrigin;

        private static int PhoneNumber;

        public ClientInfo()             //konstruktor zamiast metody void pobierający imie i nazwisko użytkownika  
        {           
            Console.WriteLine("Insert your first name");
            string firstname = Console.ReadLine();
            FirstName = firstname;
            Console.WriteLine("Insert your last name");
            string lastname = Console.ReadLine();
            LastName = lastname;
            Console.WriteLine("Where are you from");
            string country = Console.ReadLine();
            CountryOfOrigin = country;
            Console.WriteLine("Insert your phone number");
            int number = int.Parse(Console.ReadLine());
            PhoneNumber = number;
        }
        public static string GetFirstName() => FirstName;     // zwraca imie
        public static string GetLastName() => LastName;        //zwraca nazwisko
        public static string GetCountryOfOrigin() => CountryOfOrigin;  //zwraca kraj pochodzenia
        public static int GetPhoneNumber() => PhoneNumber;
        //public void SayHi()
        //{
        //    Console.WriteLine($"Hello {FirstName} {LastName}");  //wita użytkownika 
        //}

    }
}
