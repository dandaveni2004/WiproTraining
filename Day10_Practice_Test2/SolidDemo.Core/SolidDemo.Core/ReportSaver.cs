using System.IO;

namespace SolidDemo.Core
{
    public class ReportSaver
    {
        public void Save(string content, string path)
        {
            File.WriteAllText(path, content);
        }
    }
}