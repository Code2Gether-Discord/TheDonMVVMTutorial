using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TheDonMVVMTutorial.Model
{
    public class Person : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private string address;
        #endregion

        #region Properties
        public string Name 
        {
            get => name;
            set { name = value; onPropertyChanged(nameof(name)); }
        }
        public string Address 
        {
            get => address;
            set { address = value; onPropertyChanged(nameof(address)); }
        }
        #endregion

        #region Methods
        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
