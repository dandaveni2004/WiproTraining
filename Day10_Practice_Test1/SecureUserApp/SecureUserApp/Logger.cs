using System;
using System.IO;

namespace SecureUserApp
{
    public static class Logger
    {
        private static readonly string path = "log.txt";

        public static void Log(string message)
        {
            string logMessage = $"{DateTime.Now} : {message}";
            File.AppendAllText(path, logMessage + Environment.NewLine);
        }
    }
}