using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    class Gamer
    {
        
        int money = 100;

        public void MakeACar(Detail detail)
        {
            Car car = new Car();
        }

        public void BuyDetail(int x)
        {
            money -= x;
        }

        public void profit(int x)
        {
            money += x;
        }
    }
}
