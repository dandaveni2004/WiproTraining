using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Emp
    {
        private int empno;
        private string name;
        private double salary;
        // Implement Read-Write Properties 
        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    internal class PropertyEx1
    {
        static void Main()
        {
            Emp emp1=new Emp();
            emp1.Empno = 101;
            emp1.Name = "Josh";
            emp1.Salary =50000;

            Emp emp2 = new Emp();
            emp2.Empno = 102;
            emp2.Name = "Aish";
            emp2.Salary = 60000;

            Emp emp3= new Emp();
            emp3.Empno = 103;
            emp3.Name = "Akhi";
            emp3.Salary = 70000;

            Console.WriteLine("Employ Details");
            Console.WriteLine($"Employ No {emp1.Empno} Employ Name {emp1.Name} Salary {emp1.Salary}");
            Console.WriteLine($"Employ No {emp2.Empno} Employ Name {emp2.Name} Salary {emp2.Salary}");
            Console.WriteLine($"Employ No {emp3.Empno} Employ Name {emp3.Name} Salary {emp3.Salary}");
        }


    }
}
