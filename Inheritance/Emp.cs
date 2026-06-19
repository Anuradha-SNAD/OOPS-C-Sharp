using OOPS.Encapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance.Hierarchical
{
    public class Emp
    {
        public string Name { get; set; }

        public void Login()
        {
            Console.WriteLine("Employee Logged In..!");
        }
    }
    public class Developer : Emp
    {
        public void Code()
        {
            Console.WriteLine("Writing Code..!");
        }
    }
    public class Tester : Emp
    {
        public void Test()
        {
            Console.WriteLine("Testing Application..!");
        }
    }
}
