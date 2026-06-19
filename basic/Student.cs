using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.OOPS_Basics
{
    internal class Student
    {
        int id = 101;
        string name = "raju";
        public Student()
        {
            Console.WriteLine("Id = " + id);
            Console.WriteLine("Name = " + name);
        }
        static Student()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    class Student1
    {
        public int id;
        public string name;
        public Student1()
        {
            Console.WriteLine("No-Argument Contructor");
        }
       public Student1(int id,string name)//No-Arguments Constructor
        {
            this.id = id;
            this.name = name;
        }
    }
}
