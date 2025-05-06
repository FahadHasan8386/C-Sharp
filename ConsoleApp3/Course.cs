using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct DateFormat
    {
        private uint day;
        private uint month;
        private uint year;

        internal DateFormat(uint day, uint month, uint year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        internal void DayPrint()
        {
            Console.WriteLine($"Day: {this.day}");
            Console.WriteLine($"Month: {this.month}");
            Console.WriteLine($"Year: {this.year}");
        }
    }

    internal class Course
    {
        private uint id;
        private string title;
        private DateFormat launchDate;
        private int duration;

        internal uint Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        internal int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        internal Course(uint id, string title, DateFormat launchDate, int duration)
        {
            this.Id = id;
            this.Title = title;
            this.launchDate = launchDate;
            this.Duration = duration;
        }
        public void Duration_Condition()
        {
            if(duration > 120)
            {
                Console.WriteLine("Valid Duration");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine($"Course ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Duration: {Duration} days");
            Console.WriteLine("Launch Date:");
            launchDate.DayPrint();
            Duration_Condition();
        }
        internal virtual void Analysis()
        { 
            
        }
       

    }

}
