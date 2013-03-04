using ContactsManager.BusinessObjects;
using ContactsManager.Repository.Contracts;
using ContactsManager.WPF.Services.ServiceContracts;
using MEFedMVVM.ViewModelLocator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.WPF.Services
{
    [ExportService(ServiceType.Both, typeof(IContactsService))]
    public class ContactsService : IContactsService
    {
        [ImportingConstructor]
        public ContactsService(IContactsRepository<Contact> contactsRepository)
        {
            this.contactsRepository = contactsRepository;
        }

        private IContactsRepository<Contact> contactsRepository;

        public void InjectContext(object context)
        {

        }

        public string Title
        {
            get { return "Hello"; }
        }
    }
}
