using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymApp;

     interface IPersonalTrainers       //interfejs zawierający właściwości które wywołuje w klasach poszczególnych trenerów z info o nich
        {
            string Name { get; set; } 
            string CountryOfOrigin { get; set; } 
            int MrOlimpiaWins { get; set; }
            string Message { get; set; }
        }

