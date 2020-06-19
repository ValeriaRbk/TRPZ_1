using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    class Car
    {
        string name;
        public int Distance { get; private set; } //километраж
        int car_cost; //стоимость
        int profit; //прибыль

        List<Detail> car_details = new List<Detail>();

        public Car(string n)
        {
            name = n;
        }

        public void MakeACar(Detail d)
        {
            Car c = new Car("Car");
            c.car_details.Add(d);
            c.car_cost += d.Cost;
            c.Distance += d.durable;
        }

    }
}
