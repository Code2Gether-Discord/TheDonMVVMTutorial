using System;
using System.ComponentModel;
using TheDonMVVMTutorial.Model;
using System.Windows.Input;
using Prism.Commands;
using System.Collections.ObjectModel;

namespace TheDonMVVMTutorial.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<Person> _personList;
        private Person person;
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties
        public ObservableCollection<Person> PersonList
        {
            get => _personList;
            set { _personList = value; onPropertyChanged(nameof(PersonList)); }
        }
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
        public ICommand AddUserCommand { get; set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            AddUserCommand = new DelegateCommand(AddUser);

            PersonList = new ObservableCollection<Person>
            {
                new Person { FirstName = "Joe", LastName="Swanson", Address = "987 Spooner Street, Quahog, RI, USA" },
                new Person { FirstName = "Peter", LastName="Griffin", Address = "I don't know, i just have a goofy laugh." },
                new Person { FirstName = "Glann", LastName="Quagmire", Address = "Giggety"}
            };
        }
        #endregion

        #region Methods
        private void AddUser()
        {
            var newPerson = new Person
            {
                FirstName = Person.FirstName,
                LastName = Person.LastName,
                Address = Person.Address
            };

            PersonList.Add(newPerson);

            Person = newPerson;
        }

        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
