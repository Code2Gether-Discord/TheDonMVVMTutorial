using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TheDonMVVMTutorial.Model;

namespace TheDonMVVMTutorial.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Fields
        private Person person;
        #endregion

        #region Properties
        public Person Person 
        {
            get => person;
            set
            {
                person = value;
                onPropertyChanged(nameof(person));
            }
        }
        #endregion

        #region Commands
        public DelegateCommand updateMeCommand { get; set; }
        public DelegateCommand updateMyPropertiesCommand { get; set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            updateMeCommand = new DelegateCommand(updatePerson);
            updateMyPropertiesCommand = new DelegateCommand(updatePersonProperties);

            Person = new Person
            {
                Name = "Joe Swanson",
                Address = "987 Spooner Street, Quahog, RI, USA"
            };
        }
        #endregion

        #region Methods
        public void updatePerson()
        {
            // Creating a new person
            Person = new Person
            {
                Name = "Peter Griffin",
                Address = "I don't know, i just have a goofy laugh."
            };
        }

        public void updatePersonProperties()
        {
            // Updating the person members.
            Person.Name = "Glenn Quagmire";
            Person.Address = "Giggety";
        }

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
