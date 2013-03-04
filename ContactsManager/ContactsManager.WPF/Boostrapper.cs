using ContactsManager.WPF.Views;
using MEFedMVVM.ViewModelLocator;
using Microsoft.Practices.Prism.MefExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ContactsManager.WPF
{
    /// <summary>
    /// Contacts Manager - Bootstrapper
    /// ===============================
    /// 
    /// 1.  Configure AggregateCatalog add Directoty and Assembly
    /// 2.  Create Shell 
    /// 3.  Intialize Shell
    /// 4.  Return the ComposablePartCatalog or no magic will happen (IOC depends on this)
    /// </summary>
    public class Boostrapper : MefBootstrapper, IComposer
    {
        protected override void ConfigureAggregateCatalog()
        {
            this.AggregateCatalog.Catalogs.Add(new DirectoryCatalog(@"."));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Boostrapper).Assembly));
        }

        protected override DependencyObject CreateShell()
        {
            MEFedMVVM.ViewModelLocator.LocatorBootstrapper.ApplyComposer(this);
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Shell)this.Shell;
            App.Current.MainWindow.Show();
        }

        public IEnumerable<ExportProvider> GetCustomExportProviders()
        {
            //In case you want some custom export providers
            return null;
        }


        public ComposablePartCatalog InitializeContainer()
        {
            return this.AggregateCatalog;
        }
    }
}
