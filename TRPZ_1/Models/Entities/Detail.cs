using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace TRPZ_1
{
    public class Detail : INotifyPropertyChanged
    {
        private string name;
        private int price;
        private int breakage;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public int Breakage
        {
            get { return breakage; }
            set
            {
                breakage = value;
                OnPropertyChanged("Breakage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        /*
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
        */
    }
}
