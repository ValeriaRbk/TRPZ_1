using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace TRPZ_1
{
    class ViewModel : INotifyPropertyChanged
    {
        private Detail selectedDetail;

        public ObservableCollection<Detail> Details { get; set; }
        public Detail SelectedPhone
        {
            get { return selectedDetail; }
            set
            {
                selectedDetail = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ViewModel()
        {
            Details = new ObservableCollection<Detail>
            {
                new Detail {Name = "Engine", Price = 200 , Breakage = 4 },
                new Detail {Name = "Accumulator", Price = 180, Breakage = 3 },
                new Detail {Name = "Tires", Price  = 150, Breakage = 5 },
                new Detail {Name = "Generator", Price  = 170, Breakage = 4 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        /*
        List<Detail> AllDetails = new List<Detail>();

        public void NewDetail(string n, int b, int c, int r, int d)
        {
            Detail new_detail = new Detail(n, b, c, r, d);
            AllDetails.Add(new_detail);
        }

        public ViewModel()
        {
            NewDetail("engine", 3, 20, 10, 200);
            NewDetail("accumulator", 4, 15, 15, 150);
            NewDetail("tires", 3, 30, 30, 300);
        }
        */
    }
}
