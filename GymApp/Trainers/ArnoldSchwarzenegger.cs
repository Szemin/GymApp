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
        public string Ocupation { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }
        public void TrainerData()
        {
            Name = "Chris Bumstead";
            Ocupation = "Canada";
            MrOlimpiaWins = 4;
            Message = "Lift that up baby";

            Console.WriteLine($" Name: {Name} \n Ocupation: {Ocupation} \n MrOlimpia Wins: {MrOlimpiaWins} \n Message: {Message}");
        }
    }
}
