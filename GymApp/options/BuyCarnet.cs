using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.options
{ 
     class BuyCarnet
    {
        private int BasicCarnet { get; set; }
        private int RegularCarnet { get; set; }
        private int PremiumCarnet { get; set; }

        public BuyCarnet(int basicCarnet, int regularCarnet, int premiumCarnet)  //trzeba wymyślić sposób na połączenie tego z karnetami
        {
            BasicCarnet = basicCarnet;
            RegularCarnet = regularCarnet;
            PremiumCarnet = premiumCarnet;
        }
       

    }
}
