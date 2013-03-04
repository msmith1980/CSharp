using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.Configuration;
using ContactsManager.WPF.Views;

namespace ContactsManager.WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Initialize Application bootstrapper
            Boostrapper boot = new Boostrapper();
            boot.Run();
        }
    }
}