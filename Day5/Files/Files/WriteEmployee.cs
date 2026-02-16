using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Files
{
    internal class WriteEmployee
    {
        static void Main()
        {
            Employee employ = new Employee();
            employ.Empno = 1;
            employ.Name = "Pradeep";
            employ.Dept = "C#";
            employ.Desig = "Programmer";
            employ.Basic = 90000;
            FileStream fs = new FileStream(@"c:/files/employdata.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, employ);
            fs.Close();
            Console.WriteLine("Employ Data Stored in file");
        }
    }
}
