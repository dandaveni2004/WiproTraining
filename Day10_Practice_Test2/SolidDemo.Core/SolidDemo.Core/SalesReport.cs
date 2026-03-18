using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Core
{
    public class SalesReport : Report
    {
        public override string GetContent()
        {
            return "Sales Report Content";
        }
    }
}
