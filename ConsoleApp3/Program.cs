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
            DateFormat df1 = new DateFormat(1, 5, 2023);
            DateFormat df2 = new DateFormat(15, 8, 2024);

            
            Course c = new Course(101, "Basic C#", df1, 150);
            Console.WriteLine("---- Course Info ----");
            c.ShowInfo();

            
            Diploma d = new Diploma(102, "Diploma in AI", df2, 100, 3, 45);
            Console.WriteLine("---- Diploma Info ----");
            d.ShowInfo();

            
            Professional p = new Professional(103, " Cloud Computing", df2, 110, true, 5000);
            Console.WriteLine("---- Professional Info ----");
            p.ShowInfo();
        }
    }
}
