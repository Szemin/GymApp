using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    internal interface IPersonalTrainers
    {
        public string Name{get;set;}
        public string Ocupation { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }
    }
}
