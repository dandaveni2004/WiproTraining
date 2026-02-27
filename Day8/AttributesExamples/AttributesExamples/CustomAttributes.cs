using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExamples
{
    internal class CustomAttributes
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor
            | AttributeTargets.Method, AllowMultiple = false)]
        internal class CustomAttribute : System.Attribute
        {
            public string InformationString { get; set; }
        }
    }
}
