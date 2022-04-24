using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZad6
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private string email;
        private decimal payment;
        private string city;
        private int accessLevel;
        private bool details;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("PersonalInfo"); }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged("PersonalInfo"); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("PersonalInfo"); }
        }
        public decimal Payment
        {
            get { return payment; }
            set { payment = value; OnPropertyChanged("PersonalInfo"); }
        }
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("PersonalInfo"); }
        }
        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; OnPropertyChanged("PersonalInfo"); }
        }
        public bool Details
        {
            get { return details; }
            set { details = value; OnPropertyChanged("PersonalInfo"); }
        }

        public string PersonalInfo
        {
            get
            {
                return name + " " + surname;
            }
        }
        public override string ToString()
        {
            return name + " " + surname;

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
