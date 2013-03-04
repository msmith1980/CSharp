using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.BusinessObjects
{
    public class Person : BusinessBase
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged<string>(() => FirstName);
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged<string>(() => LastName);
            }
        }

        private string initials;

        public string Initials
        {
            get { return initials; }
            set
            {
                initials = value;
                OnPropertyChanged<string>(() => Initials);
            }
        }


        public Person(int personID)
            : base(personID)
        {

        }

        public Person()
        {

        }
    }
}
