using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GymApp.options;

namespace GymApp
{
    public class UserData
    {
        UserData userData = new();
        public static void UserProfile()
        {
            Console.WriteLine($"First Name: {ClientInfo.GetFirstName()}");
            Console.WriteLine($"Last Name: {ClientInfo.GetLastName()}");
            Console.WriteLine($"Country of origin: {ClientInfo.GetCountryOfOrigin()}");
            Console.WriteLine($"Phone number: {ClientInfo.GetPhoneNumber()}");
        }     
       
    }
}
