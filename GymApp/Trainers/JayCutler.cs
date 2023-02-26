using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Trainers
{
     class JayCutler : IPersonalTrainers
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }
        public void TrainerData()
        {
            Name = "Jay Cutler";
            CountryOfOrigin = "USA";
            MrOlimpiaWins = 4;
            Message = "I'm big";

            Console.WriteLine($" Name: {Name} \n Country Of Origin: {CountryOfOrigin} \n MrOlimpia Wins: {MrOlimpiaWins} \n Message: {Message}");
        }
    }
}
