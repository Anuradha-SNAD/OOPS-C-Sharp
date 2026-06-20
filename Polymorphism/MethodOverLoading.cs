using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism
{
    public class MethodOverLoading
    {
        public int Add(int a)
        {
            return a;
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
