using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Trainers
{
     class RonnieColeman :IPersonalTrainers
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }
        public void TrainerData()
        {
            Name = "Ronnie Coleman";
            CountryOfOrigin = "USA";
            MrOlimpiaWins = 8;
            Message = "Lightweight baby";

            Console.WriteLine($" Name: {Name} \n Country Of Origin: {CountryOfOrigin} \n MrOlimpia Wins: {MrOlimpiaWins} \n Message: {Message}");
        }
    }
}
