using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Employ
    {
        public void Show()
        {
            Console.WriteLine("Show Method from Employ Class...");
        }
    }

    class Student : Employ
    {
        private int sid;
        private string name;
        private double cgpa;

        public Student(int sid, string name, double cgpa)
        {
            this.sid = sid;
            this.name = name;
            this.cgpa = cgpa;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Show Method from Student Class...");
        }
    }
    internal class BaseExample1
    {
        static void Main()
        {
            Student student = new Student();
            student.Show();
        }
    }
}
