using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    class DetailStorage
    {
        List<Detail> AllDetails = new List<Detail>();

        public void NewDetail(string n, int b, int c, int r, int d)
        {
            Detail new_detail = new Detail(n, b, c, r, d);
            AllDetails.Add(new_detail);
        }

        public void MakeDetails()
        {
            NewDetail("engine", 3, 20, 10, 200);
            NewDetail("accumulator", 4, 15, 15, 150);
            NewDetail("tires", 3, 30, 30, 300);
        }
    }
}
