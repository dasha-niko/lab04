using 
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Nikolayuk04
{
    internal class EditPersonViewModel
    {
        private ICommand editCommand;
        public Person CurrentPerson { get; }

        public EditPersonViewModel()
        {
            CurrentPerson = StationManager.CurrentPerson;
        }



      

        private bool CanEditExecute(object obj)
        {
            return !String.IsNullOrWhiteSpace(CurrentPerson.Name) &&
                  !String.IsNullOrWhiteSpace(CurrentPerson.LastName) &&
                  !String.IsNullOrWhiteSpace(CurrentPerson.Email);
        }



        private void IsDateCorrect()
        {
            if ((DateTime.Now.Year - CurrentPerson.Birthday.Year) > 135)
            {
                throw new PersonTooOldException(CurrentPerson.Birthday);
            }
            else if (CurrentPerson.Birthday > DateTime.Now)
            {
                throw new PersonNotBornYetException(CurrentPerson.Birthday);
            }
        }


        private void ValidateFullName(string name, string lastName)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(name))
            {
                throw new InvalidNameException(name);
            }
            if (!regex.IsMatch(lastName))
            {
                throw new InvalidLastNameException(lastName);
            }
        }


    }
}
