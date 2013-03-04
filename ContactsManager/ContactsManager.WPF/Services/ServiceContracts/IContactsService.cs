using ContactsManager.BusinessObjects;
using ContactsManager.Repository.Contracts;
using MEFedMVVM.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.WPF.Services.ServiceContracts
{
    public interface IContactsService : IContextAware
    {
        string Title { get; }
    }
}
