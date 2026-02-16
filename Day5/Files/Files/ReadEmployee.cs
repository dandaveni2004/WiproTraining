using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class ReadEmployee
    {
        static void Main()
        {
            FileStream fs = new FileStream("c:/files/employdata.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee employ = (Employee)formatter.Deserialize(fs);
            Console.WriteLine(employ);
            fs.Close();
        }
    }
}
