using CodeGenerator.Infrastructure.Interfaces;
using Generator.Views;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.ModuleDefinitions
{
    public class CodeGeneratorModule : IModule
    {
        public CodeGeneratorModule(IUnityContainer container, IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            this.container = container;
            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            ConfigureServices();
            ConfigureEvents();
            ConfigureViews();
        }

        private void ConfigureServices()
        {
           // container.RegisterType(typeof(IGenerator), null);
        }

        private void ConfigureEvents()
        {

        }

        private void ConfigureViews()
        {
            regionManager.RegisterViewWithRegion("ControlRegion", typeof(GeneratorView));
        }

        IUnityContainer container;
        IEventAggregator eventAggregator;
        IRegionManager regionManager;
    }
}
