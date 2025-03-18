using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Details");
            Console.WriteLine("Your id is = " + id);
            Console.WriteLine("Your name is = " + name);

        }
    }
}
