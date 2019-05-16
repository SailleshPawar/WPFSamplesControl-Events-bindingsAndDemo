using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class Craftsman : INotifyPropertyChanged
    {
        private int _age;

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get => _age;
            set {  
                _age = value;
                OnPropertyChanged();
            }
        }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }

    public class Person
    {
        public string PersonName { get; set; }
    }
}
