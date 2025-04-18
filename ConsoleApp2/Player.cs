using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct date
    {
        public int day;
        public int month;
        public int year;
    }


    internal class Player
    {
      
        private int id;
        private string name;
        private string description;
        private float age;
       

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public float Age
        {
            get { return age; }
            set { age = value; }
        }
       

    }
}
