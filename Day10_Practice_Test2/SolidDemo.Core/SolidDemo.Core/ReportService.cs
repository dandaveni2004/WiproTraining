using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.Core
{
    public class ReportService
    {
        private readonly ReportGenerator _generator;
        private readonly IReportFormatter _formatter;
        private readonly ReportSaver _saver;

        public ReportService(
            ReportGenerator generator,
            IReportFormatter formatter,
            ReportSaver saver)
        {
            _generator = generator;
            _formatter = formatter;
            _saver = saver;
        }

        public void Process(string path)
        {
            var content = _generator.GenerateReport();
            var formatted = _formatter.Format(content);
            _saver.Save(formatted, path);
        }
    }
}
