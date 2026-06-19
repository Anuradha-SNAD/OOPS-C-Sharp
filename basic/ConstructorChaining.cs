using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.OOPS_Basics
{
    public class ConstructorChaining
    {
        public string Name {  get; set; }
        public int id { get; set; }
        public int marks {  get; set; }

        public ConstructorChaining(string Name)
        {
            this.Name = Name;
        }

        public ConstructorChaining(string Name,int id) : this(Name)
        {
            this.id = id;
        }
        public ConstructorChaining(string Name, int id,int marks) : this(Name,id)
        {
            this.marks = marks;
        }
    }
}
