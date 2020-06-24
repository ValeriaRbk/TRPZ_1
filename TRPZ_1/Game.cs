using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TRPZ_1
{
    class Game 
    {
        
        static void RunCar()
        {
            Car c = new Car("");
            Player p = new Player();

            int profit = (c.Distance / 100) * 50;
            p.Purse += profit;
        }
        
    }
}
