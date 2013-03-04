using ContactsManager.BusinessObjects;
using ContactsManager.Data;
using ContactsManager.Repository.Contracts;
using MEFedMVVM.ViewModelLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Repository.Implementations
{
    [ExportService(ServiceType.Both, typeof(IContactsRepository<Contact>))]
    public class ContactRepository : IContactsRepository<Contact>
    {
        ContactsStoreEntities contactEntities;

        public ContactRepository()
        {
            contactEntities = new ContactsStoreEntities();
        }

        public List<Contact> GetContacts()
        {
            var data = (from c in contactEntities.People select c).ToList();

            return (from d in data
                    select new Contact
                    {
                        Addresses = d.Addresses.Select(x => new AddressInfo { }).ToList(),
                        Person = new BusinessObjects.Person
                        {
                            FirstName = d.First_Name
                        }
                    }).ToList();

        }

        public List<Contact> GetContactsWhere(Func<IEnumerable<Contact>> contactPredicate)
        {
            throw new NotImplementedException();
        }

        public void SaveContact(Contact contactToSave)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            if (contactEntities != null)
            {
                contactEntities.Database.Connection.Close();
                contactEntities = null;
            }
        }
    }
}
