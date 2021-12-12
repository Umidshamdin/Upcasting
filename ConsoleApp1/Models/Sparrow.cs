using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Sparrow : Bird
    {
        public string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("sparrow eating");
        }

        public override void Sound()
        {
            Console.WriteLine("Sparrow sound");
        }
    }
}
