using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Ant:İnsect
    {
        public int FootCount { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Ant eating");

        }
        public override void Sound()
        {
            Console.WriteLine("Ant sound");
        }
    }
}
