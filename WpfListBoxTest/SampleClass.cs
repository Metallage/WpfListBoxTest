using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfListBoxTest
{
    class SampleClass: INotifyPropertyChanged
    {
        private string first = String.Empty;
        private string second = String.Empty;
        private string third = String.Empty;
        private string fouth = String.Empty;

        public string First
        {
            get
            {
                return first;
            }
            set
            {
                if(value!=first)
                {
                    first = value;
                    OnPropertyCahnged(this, "First");
                }
            }
        }

        public string Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value != second)
                {
                    second = value;
                    OnPropertyCahnged(this, "Second");
                }
            }
        }


        public string Third
        {
            get
            {
                return third;
            }
            set
            {
                if (value != third)
                {
                    third = value;
                    OnPropertyCahnged(this, "Third");
                }
            }
        }


        public string Fouth
        {
            get
            {
                return fouth;
            }
            set
            {
                if (value != fouth)
                {
                    fouth = value;
                    OnPropertyCahnged(this, "Fouth");
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
