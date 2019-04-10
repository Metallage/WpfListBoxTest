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

        private ObservableCollection<string> thirds = new ObservableCollection<string>();

        private ObservableCollection<string> fouths = new ObservableCollection<string>();

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

        public ObservableCollection<string> Thirds
        {
            get
            {
                return thirds;
            }
            set
            {
                if (value != thirds)
                {
                    thirds = value;
                    OnPropertyCahnged(this, "Thirds");
                }
            }
        }



        public ObservableCollection<string> Fouths
        {
            get
            {
                return fouths;
            }
            set
            {
                if (value != fouths)
                {
                    fouths = value;
                    OnPropertyCahnged(this, "Fouths");
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
