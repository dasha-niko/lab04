using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nikolayuk04
{
    [Serializable]
    internal class Person : INotifyPropertyChanged
    {
        #region Fields
        private string _name;
        private string _lastName;
        private string _email;
        private DateTime _birthday;
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }



        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
                OnPropertyChanged();
                OnPropertyChanged("IsAdult");
                OnPropertyChanged("IsBirthday");
                OnPropertyChanged("SunSign");
                OnPropertyChanged("ChineseSign");

            }
        }
        public bool IsAdult
        {
            get
            {
                return ((DateTime.Now.Year - _birthday.Year) >= 18) ? true : false;
            }
        }
        public string SunSign
        {
            get
            {
                return WesternSigns(_birthday);
            }
        }
        public string ChineseSign
        {
            get
            {
                return ChineseSigns(_birthday);
            }
        }
        public bool IsBirthday
        {
            get
            {
                return (DateTime.Now.Day == _birthday.Day && DateTime.Now.Month == _birthday.Month) ? true : false;
            }
        }
        #endregion

        #region Constructor

        public Person(string name, string lastName, string email, DateTime birthday)
        {
            _name = name;
            _lastName = lastName;
            _email = email;
            _birthday = birthday;
        }

        public Person(string name, string lastName, string email) : this(name, lastName, email, DateTime.Now)
        {
        }

        public Person(string name, string lastName, DateTime birthday) : this(name, lastName, "undefined@mail.com", birthday)
        {
        }
        #endregion

        private static string WesternSigns(DateTime birthday)
        {
            string res = "";
            int month = birthday.Month;
            int day = birthday.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                res = "Aries";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 20))
            {
                res = "Taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
            {
                res = "Gemini";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
            {
                res = "Cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 23))
            {
                res = "Leo";
            }
            else if ((month == 8 && day >= 24) || (month == 9 && day <= 23))
            {
                res = "Virgo";
            }
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
            {
                res = "Libra";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                res = "Scorpio";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
            {
                res = "Saggitarius";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
            {
                res = "Capricorn";
            }
            else if ((month == 1 && day >= 21) || (month == 2 && day <= 20))
            {
                res = "Aquarius";
            }
            else if ((month == 2 && day >= 21) || (month == 3 && day <= 20))
            {
                res = "Pisces";
            }

            return res;

        }


        private static string ChineseSigns(DateTime birthday)
        {
            int year = birthday.Year;
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Goat"; }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
