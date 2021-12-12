using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    abstract class Animal
    {

        public abstract void Eat();

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
        
    }
}
