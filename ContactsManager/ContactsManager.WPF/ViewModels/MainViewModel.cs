using ContactsManager.Infrastructure;
using MEFedMVVM.ViewModelLocator;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.WPF.ViewModels
{
    [ExportViewModel("MainViewModel")]
    public class MainViewModel : ObservableObject
    {
        public static string ApplicationTitle
        {
            get
            {
                return LocalResources.AppTitle.ToString();
            }
        }

        [ImportingConstructor]
        public MainViewModel()
        {
            
        }

    }
}
