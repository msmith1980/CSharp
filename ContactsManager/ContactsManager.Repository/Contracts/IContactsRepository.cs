
using ContactsManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactsManager.Repository.Contracts
{
    public interface IContactsRepository<T>: IDisposable where T : class 
    {
        List<Contact> GetContacts();
        List<Contact> GetContactsWhere(Func<IEnumerable<Contact>> contactPredicate);
        void SaveContact(Contact contactToSave);
    }
}
