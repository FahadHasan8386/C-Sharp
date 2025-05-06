using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Diploma:Course
    {
        private int year_of_experience;
        private int enrolled_std;

        internal int Year_of_experience
        {
            get { return this.year_of_experience; }
            set { this.year_of_experience = value; }
        }

        internal int Enrolled_std
        {
            get { return this.enrolled_std; }
            set{this.enrolled_std = value; }
        }

        internal Diploma(uint id, string title, DateFormat launchDate, int duration, int year_of_experience, int enrolled_std) : base(id, title, launchDate, duration)
        {
            this.year_of_experience = year_of_experience;
            this.enrolled_std= enrolled_std;
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Year_of_experience: {year_of_experience}");
            Console.WriteLine($"Enrolled_std: {enrolled_std}");
            Analysis();
        }
        internal override void Analysis()
        {
            if (enrolled_std > 50)
            {
                Console.WriteLine("HIghly Demandable");
            }
            else if (enrolled_std > 30 && 50 > enrolled_std)
            {
                Console.WriteLine("Modarate");
            }
            else
            {
                Console.WriteLine("Less");
            }
        }


    }

  
}
