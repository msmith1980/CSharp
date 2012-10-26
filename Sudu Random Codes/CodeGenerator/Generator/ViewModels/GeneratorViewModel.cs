using CodeGenerator.Infrastructure.Interfaces;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.ViewModels
{
    public class GeneratorViewModel : BaseViewModel
    {
        public string Text
        {
            get
            {
                return "I have loaded";
            }
        }

        public GeneratorViewModel(IGenerator generator,IEventAggregator eventAggregator)
        {
            this._generator = generator;
            this._eventAggregator = eventAggregator;

        }

        IGenerator _generator;
        IEventAggregator _eventAggregator;
    }
}
