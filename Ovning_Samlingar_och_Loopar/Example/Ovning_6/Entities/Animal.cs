using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_6.Entities
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Run()
        {

            Console.WriteLine("Whoo jag springer");
        }
        
        public void Eat()
        {

            Console.WriteLine("Nu är jag mätt!");
        }

        public virtual int GetAge()
        {

            return Age;
        }
    }

    public class Dog: Animal
    {
        public override int GetAge()
        {
            return Age * 7;
        }
    }

    public class Cat: Animal
    {

        public override int GetAge()
        {
            return Age * 5;
        }
    }

    public class Rabbit: Animal
    {

        public override int GetAge()
        {
            return Age * 15;
        }
    }
}
