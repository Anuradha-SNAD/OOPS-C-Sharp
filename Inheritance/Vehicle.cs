using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance.Single_level
{
    public class Vehicle
    {
        public string brand {  get; set; }
        public int wheels {  get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle Started...");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle Stopped...");
        }
    }

}
