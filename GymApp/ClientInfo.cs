using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class ClientInfo
    {
        private string? FirstName;
        private string? LastName;      
        public ClientInfo()
        {           
            Console.WriteLine("Insert your first name");
            string? firstname = Console.ReadLine();
            FirstName = firstname;
            Console.WriteLine("Insert your first name");
            string? lastname = Console.ReadLine();
            LastName = lastname;           
        }
        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;

        public void SayHi()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }

    }
}
