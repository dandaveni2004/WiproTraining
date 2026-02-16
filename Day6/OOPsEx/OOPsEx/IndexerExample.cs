using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class IndexerExample
    {
        string[] names = new string[5];

        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        static void Main()
        {
            IndexerExample indexerEx = new IndexerExample();
            indexerEx[0] = "Karthik";
            indexerEx[1] = "Ganesh";
            indexerEx[2] = "Pradeep";
            indexerEx[3] = "Raju";
            indexerEx[4] = "Karthik";

            foreach (object o in indexerEx.names)
            {
                Console.WriteLine(o);
            }
        }
    }
}
