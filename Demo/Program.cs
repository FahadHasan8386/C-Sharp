using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Fahad", 25, 55000.50, "Business");
            Employee e2 = new Employee(102, "Sarah", 30, 67000, "Engineering");
            Employee e3 = new Employee(103, "John", 28, 72000.75, "Medical");
            Employee e4 = new Employee(104, "Ayesha", 27, 48000, "Design");
            Employee e5 = new Employee(105, "Ali", 35, 53000, "Education");

            e1.print();
            e2.print();
            e3.print();
            e4.print();
            e5.print();

            Console.ReadKey();

        }
    }
}
