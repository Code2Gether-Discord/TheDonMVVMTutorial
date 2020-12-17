using System;
using System.ComponentModel;

namespace TheDonMVVMTutorial.Model
{
    public class Person : INotifyPropertyChanged
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string address;
        #endregion

        #region Properties
        public string FirstName 
        {
            get => firstName;
            set { firstName = value; onPropertyChanged(nameof(firstName)); }
        }
        public string LastName
        {
            get => lastName;
            set { lastName = value; onPropertyChanged(nameof(lastName)); }
        }
        public string Address 
        {
            get => address;
            set { address = value;  onPropertyChanged(nameof(address)); }
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
