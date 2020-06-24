using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace TRPZ_1.Data
{
    public class ViewModel : INotifyPropertyChanged
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

        public ApplicationViewModel()
        {
            Details = new ObservableCollection<Detail>
            {
                new Detail { Title="iPhone 7", Company="Apple", Price=56000 },
                new Detail {Title="Galaxy S7 Edge", Company="Samsung", Price =60000 },
                new Detail {Title="Elite x3", Company="HP", Price=56000 },
                new Detail {Title="Mi5S", Company="Xiaomi", Price=35000 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
