using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    class Car
    {
        int distance;
        int cost;
        int profit;
        List<Detail> details = new List<Detail>();

        public Car()
        {

        }

        public void AddDetail(Detail new_detail) { details.Add(new_detail); }
    }
}
