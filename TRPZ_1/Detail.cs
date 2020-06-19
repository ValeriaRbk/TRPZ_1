using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    class Detail
    {
        string name;
        int breakages; // кол-во возможных поломок
        public int Cost { get; private set; } // стоимость детали
        int repair_cost; //стоимость ремонта поломки
        public int durable { get; private set; } //километры до поломки

        public Detail(string n, int b, int c, int r, int d)
        {
            name = n;
            breakages = b;
            Cost = c;
            repair_cost = c;
            durable = d;
        }

        public void Breakage(Detail d)
        {
            int i = 0;
            while (i <= d.durable)
            {
                i++;
            }
        }

    }
}
