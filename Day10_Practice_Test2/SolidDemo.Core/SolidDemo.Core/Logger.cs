using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SolidDemo.Core
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private static readonly string path = "log.txt";

        private Logger() { }

        public static Logger Instance => _instance;

        public void Log(string message)
        {
            File.AppendAllText(path, DateTime.Now + " : " + message + "\n");
        }
    }
}
