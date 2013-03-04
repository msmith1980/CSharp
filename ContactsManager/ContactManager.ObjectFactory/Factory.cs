using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsManager.Data;

namespace ContactsManager.ObjectFactory
{
    public abstract class Factory<T>
    {
        public abstract T Create(Person person, IEnumerable<Address> addresses);
    }
}
