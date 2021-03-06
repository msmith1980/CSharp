﻿using CodeGenerator.Infrastructure.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generator.Services
{
    public class CodeWithPattern : BaseGenerator
    {
        protected IGenerator generator;

        public CodeWithPattern(IGenerator generator)
        {
            this.generator = generator;
            Generate();
        }

        public override void Generate()
        {
            generator.Generate();
        }

        AutoResetEvent generateEvent = new AutoResetEvent(false);

        public string Pattern
        {
            get;
            set;
        }
    }
}
