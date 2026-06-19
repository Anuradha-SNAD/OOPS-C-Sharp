using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Encapsulation
{
    internal class Employee
    {
        private int id;
        private string name;
        private int salary;

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }

        public override string? ToString()
        {
            return "Employee[Id = "+id+", Name = "+name+", Salary = "+salary+"]";
        }
    }
}
