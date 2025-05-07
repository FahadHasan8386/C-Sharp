using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphic object creation
            Course course1 = new Diploma(201, "Diploma in Cybersecurity", new DateFormat(10, 6, 2025), 120, 4, 60);
            Course course2 = new Professional(202, "Professional in Data Science", new DateFormat(1, 9, 2025), 100, false, 4500);

            // Calling overridden methods polymorphically
            Console.WriteLine("---- Course 1 Info ----");
            course1.ShowInfo();  // Will call Diploma's ShowInfo()

            Console.WriteLine("---- Course 2 Info ----");
            course2.ShowInfo();  // Will call Professional's ShowInfo()

        }
    }
}
