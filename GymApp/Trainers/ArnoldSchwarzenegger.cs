using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Trainers
{
     class ArnoldSchwarzenegger : IPersonalTrainers
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }
        public void TrainerData()
        {
            Name = "Arnold Schwarzenegger";
            CountryOfOrigin = "Austria-USA";
            MrOlimpiaWins = 7;
            Message = "ASTA LAWISTA";

            Console.WriteLine($" Name: {Name} \n Country Of Origin: {CountryOfOrigin} \n MrOlimpia Wins: {MrOlimpiaWins} \n Message: {Message}");
        }
    }
}
