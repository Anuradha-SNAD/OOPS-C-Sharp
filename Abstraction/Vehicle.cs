using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Abstraction
{
   public abstract class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
        public abstract void Start();

        public void Stop()
        {
            Console.WriteLine("Stopped..!");
        }
    }
    public class V : Vehicle
    {
        public V()
        {
            Console.WriteLine("V Constructor..!");
        }
        public override void Start()
        {
            Console.WriteLine("Started..!");
        }
    }
}
