using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance.Single_level
{
    public class Animal
    {
        public string AnimalName {  get; set; }
        public int NoOfLegs {  get; set; }

        public Animal()
        {
            Console.WriteLine("Animal Constructor Loaded...");
        }

        public void Sound()
        {
            Console.WriteLine("Animal will sound");
        }
    }
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor Loaded...");
        }
    }
}
