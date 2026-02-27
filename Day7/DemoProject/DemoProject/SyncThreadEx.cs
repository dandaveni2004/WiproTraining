using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class SyncThreadEx
    {
        class Demo
        {
            public void ShowMessage(string name)
            {
                lock (this)
                {
                    Console.Write($"Hello {name}");
                    Thread.Sleep(1000);
                    Console.WriteLine(" How are You...");
                }
            }
        }
        internal class SyncEx
        {
            Demo demo;
            SyncEx(Demo demo)
            {
                this.demo = demo;
            }

            public void Karthik()
            {
                demo.ShowMessage("Karthik");
            }

            public void Ganesh()
            {
                demo.ShowMessage("Ganesh");
            }

            public void Raju()
            {
                demo.ShowMessage("Raju");
            }

            static void Main()
            {
                Demo demo = new Demo();
                SyncEx syncEx = new SyncEx(demo);

                ThreadStart th1 = new ThreadStart(syncEx.Karthik);
                ThreadStart th2 = new ThreadStart(syncEx.Ganesh);
                ThreadStart th3 = new ThreadStart(syncEx.Raju);

                Thread t1 = new Thread(th1);
                Thread t2 = new Thread(th2);
                Thread t3 = new Thread(th3);

                t1.Start();
                t2.Start();
                t3.Start();
            }
        }
    }
}
