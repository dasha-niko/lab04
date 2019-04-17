using System;

using System.Windows.Input;

namespace Nikolayuk04
{
    internal class AddPerson
    {
        private ICommand addCommand;
        public Person CurrentPerson { get; }


        public AddPerson()
        {
            CurrentPerson = new Person("", "", "");
            StationManager.CurrentPerson = CurrentPerson;
        }
        //public ICommand AddCommand
        //{
        //    get
        //    {
        //        return addCommand ?? (addCommand = new RelayCommand<object>(AddImplementation, CanAddExecute));
        //    }
        //}

        private bool CanAddExecute(object obj)
        {
            return !String.IsNullOrWhiteSpace(CurrentPerson.Name) &&
                   !String.IsNullOrWhiteSpace(CurrentPerson.LastName) &&
                   !String.IsNullOrWhiteSpace(CurrentPerson.Email);
        }

        
    }
}
