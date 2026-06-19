using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Encapsulation
{
    public class Students
    {
        private int id;
        private string name;
        private int marks;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
               name = value; 
            }
        }
        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if(value > 0)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Invalid Marks");
                }

            }
        }
    }
}
