using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class ClientInfo
    {        
        private static string? FirstName;              
        private static string? LastName;               
        public ClientInfo()             //konstruktor zamiast metody void pobierający imie i nazwisko użytkownika  
        {           
            Console.WriteLine("Insert your first name");
            string? firstname = Console.ReadLine();
            FirstName = firstname;
            Console.WriteLine("Insert your last name");
            string? lastname = Console.ReadLine();
            LastName = lastname;           
        }
        public static string? GetFirstName() => FirstName;     // zwraca imie
        public static string? GetLastName() => LastName;        //zwraca nazwisko

        public void SayHi()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");  //wita użytkownika 
        }

    }
}
