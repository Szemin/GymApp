using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class UserData
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string City { get; set; }
       public int PhoneNumber { get; set; }
       public DateTime DayOfBirth{ get; set; }
        
        public static void UserPhone()
        {
            //Console.WriteLine("Insert your phone number");
            //int phonenumber = int.Parse(Console.ReadLine());
            //phonenumber = PhoneNumber;
            //ClientInfo client = new ClientInfo();
            //string firstName = client.GetFirstName();
            //FirstName = firstName;

            Console.WriteLine($"First Name: {ClientInfo.GetFirstName()}");

            //Console.WriteLine($"{client.GetLastName()}");
        }
    }
}
