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

        public GeneratorViewModel(IEventAggregator eventAggregator)
        {

        }
    }
}
