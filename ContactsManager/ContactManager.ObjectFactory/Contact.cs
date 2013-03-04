using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsManager.BusinessObjects;
using ContactsManager.Infrastructure;

namespace ContactsManager.ObjectFactory
{
    public class Contact : ObservableObject
    {
        private Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }

        private IList<Address> addresses;

        public IList<Address> Addresses
        {
            get { return addresses; }
            set { addresses = value; }
        }


    }
}
