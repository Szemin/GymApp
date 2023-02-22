using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class UserData
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public double PinNumber { get; set; }
        public string FirstName;
        public UserData()
        {
            ClientInfo client = new ClientInfo();
            string firstName = client.GetFirstName();
            FirstName = firstName;

            //Console.WriteLine($"{client.GetFirstName()}");
            //Console.WriteLine($"{client.GetLastName()}");
        }
    }
}
