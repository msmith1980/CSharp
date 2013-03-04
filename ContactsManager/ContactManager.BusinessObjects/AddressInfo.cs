using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.BusinessObjects
{
    public class AddressInfo : BusinessBase
    {
        private int personID;

        public int PersonID
        {
            get { return personID; }
            set
            {
                personID = value;
                OnPropertyChanged<int>(() => PersonID);
            }
        }

        private string addressLine1;

        public string AddressLine1
        {
            get { return addressLine1; }
            set
            {
                addressLine1 = value;
                OnPropertyChanged<string>(() => AddressLine1);
            }
        }

        private string addressLine2;

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        private string addressLine3;

        public string AddressLine3
        {
            get { return addressLine3; }
            set { addressLine3 = value; }
        }
        

        public AddressInfo(int addressID)
            : base(addressID)
        {

        }

        public AddressInfo()
        {

        }
    }
}
