using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism
{
    public class MethodOverriding
    {
        public virtual  void Method()
        {
            Console.WriteLine("Parent Method...!");
        }
    }
    public class A : MethodOverriding
    {
        public override void Method()
        {
            Console.WriteLine("Child A Method");
        }

    }
    public class B : MethodOverriding
    {
        public override void Method()
        {
            Console.WriteLine("Child B Method");
        }

    }
}
