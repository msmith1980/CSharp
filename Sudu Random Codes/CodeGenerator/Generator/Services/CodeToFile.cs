using CodeGenerator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Services
{
    public class CodeToFile: BaseGenerator
    {
        protected IGenerator generator;

        public CodeToFile(IGenerator generator)
        {
            this.generator = generator;
        }

        public override void Generate()
        {

        }

        public string FilePath { get; set; }
        public int NumberOfFiles { get; set; }
        public int NumberOfItemsPerFile { get; set; }
    }
}
