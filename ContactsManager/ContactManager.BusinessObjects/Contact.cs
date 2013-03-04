using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.BusinessObjects
{
    public class Contact
    {
        public List<AddressInfo> Addresses { get; set; }

        public Person Person { get; set; }
    }
}
