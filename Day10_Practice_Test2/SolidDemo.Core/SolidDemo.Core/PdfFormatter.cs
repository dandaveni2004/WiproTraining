using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Core
{
    public class PdfFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "PDF: " + content;
        }
    }
}
