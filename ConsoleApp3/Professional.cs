using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Professional : Course
    {
        private bool is_available_globally;
        private int costing;

        internal bool Is_available_globally
        {
            get { return this.is_available_globally; }
            set { this.is_available_globally = value; }
        }
        internal int Costing
        {
            get { return this.costing; }
            set { this.costing = value; }
        }
        internal Professional(uint id, string title, DateFormat launchDate, int duration, bool is_available_globally, int costing) : base(id, title, launchDate, duration)
        {
            this.is_available_globally = is_available_globally;
            this.costing = costing;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Is_available_globally: {is_available_globally}");
            Console.WriteLine($"Costing: {costing}");
            Analysis();
        }
        internal override void Analysis()
        {
            if (costing > 10000)
            {
                Console.WriteLine("Expensive");
            }
            else if (costing > 7000 && 10000 > costing)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("General");
            }
        }
    }

}
    
