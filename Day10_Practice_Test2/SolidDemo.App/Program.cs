using System;
using SolidDemo.Core;

namespace SolidDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ReportGenerator();
            var formatter = new PdfFormatter();
            var saver = new ReportSaver();

            var service = new ReportService(generator, formatter, saver);

            service.Process("report.txt");

            Logger.Instance.Log("Report Processed Successfully");

            Console.WriteLine("Done");
        }
    }
}