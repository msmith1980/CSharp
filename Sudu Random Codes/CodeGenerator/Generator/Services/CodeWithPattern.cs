using CodeGenerator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Services
{
    public class CodeWithPattern : BaseGenerator
    {
        protected IGenerator generator;

        public CodeWithPattern(IGenerator generator, string pattern, int required)
            : base(required)
        {
            this.generator = generator;
            this.pattern = pattern;
        }

        protected override void Generate()
        {
            throw new NotImplementedException();
        }

        string pattern = String.Empty;

    }
}
