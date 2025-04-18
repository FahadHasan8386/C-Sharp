using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        //Class Fields
        private int id;
        private string name;
        private int age;
        private double salary;
        private string department;


        //Constructor
        public Employee(int id,String name,int age ,double salary,string department) {
            this.id = id;
            this.name = name;   
            this.age = age;
            this.salary = salary;
            this.department = department;
        }

        /*For 
        //Set Method
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        //For Get Method
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getAge(int age)
        {
            return age;
        }
        public int getSalary(int salary)
        {
            return salary;
        }
        */

        //For Print 
        public void print()
        {
            Console.WriteLine("ID        : " + id);
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("Age       : " + age);
            Console.WriteLine("Salary    : $" + salary);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("---------------------------");
        }

    }
}
