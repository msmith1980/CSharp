using CodeGenerator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Services
{
    public class BaseGenerator : IGenerator
    {

        public int CodesRequired
        {
            get;
            set;
        }

        public int LengthReguired
        {
            get;
            set;
        }

        public BaseGenerator()
        {
            foreach (char letter in Enumerable.Range(65, 26).ToList().ConvertAll(delegate(int value) { return (char)value; }))
            {
                //breakpoint here to confirm
            }
        }

        public virtual void Generate() { }
    }
}
