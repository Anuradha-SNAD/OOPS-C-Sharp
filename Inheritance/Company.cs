using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance.Multi_level
{
    public class Company
    {
        public string CompanyName { get; set; }

        public void CompanyInfo()
        {
            Console.WriteLine("OpenAI Company");
        }
    }
    public class Department : Company 
    {
        public string DepartmentName { get; set; }
        public void DepartmentInfo()
        {
            Console.WriteLine("SDE Department");
        }
    }
    public class Team : Department
    {
        public int members;

        public void Teaminfo()
        {
            Console.WriteLine("Backend Team");
        }
    }

}
