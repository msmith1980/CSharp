using ContactsManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.ObjectFactory
{
    public class ContactFactory : Factory<Contact>
    {

        public override Contact Create(Person person, IEnumerable<Address> addresses)
        {
            return new Contact {
            };
        }
    }
}
