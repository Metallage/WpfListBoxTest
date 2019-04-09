using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfListBoxTest
{
    class ViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<SampleClass> itsSource = new ObservableCollection<SampleClass>();


        public ObservableCollection<SampleClass> ItsSource
        {
            get
            {
                return itsSource;
            }
            set
            {
                if(value != itsSource)
                {
                    itsSource = value;
                    OnPropertyCahnged(this, "ItsSource");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyCahnged(object sender, string propertyName)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
        }
    }
}
