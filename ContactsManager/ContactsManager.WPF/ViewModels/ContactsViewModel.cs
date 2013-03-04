using ContactsManager.WPF.Services.ServiceContracts;
using MEFedMVVM.ViewModelLocator;
using System.ComponentModel.Composition;

namespace ContactsManager.WPF.ViewModels
{
    [ExportViewModel("ContactsViewModel")]
    public class ContactsViewModel
    {
        public string Title
        {
            get
            {
                return contactsService.Title;
            }
        }

        [ImportingConstructor]
        public ContactsViewModel(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }

        private IContactsService contactsService;
    }
}
