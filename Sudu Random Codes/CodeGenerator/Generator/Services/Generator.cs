using CodeGenerator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Services
{
    public abstract class BaseGenerator : IGenerator
    {
        protected int codesRequired;

        public BaseGenerator(int numberRequired)
        {
            this.codesRequired = numberRequired;
        }

        public abstract void Generate();
    }
}
