using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting
            Ant ant = new Ant();

            Animal ant1 = ant;

            Animal ant2 = new Ant();

            Animal bird = new Sparrow();

            Animal bird2 = new Sparrow();





            Animal[] Animal = { ant, ant1, ant2, bird, bird2 };

            foreach (var item in Animal)
            {
                item.Eat();
            }



            #endregion

            #region Downcasting


            Animal sparrow1 = new Sparrow();

            Sparrow sparrow2 = (Sparrow)sparrow1;

            object[] objects = { 13, 12, sparrow1, sparrow2 };
            foreach (var item in objects)
            {
                if(item is Sparrow)
                {
                    ((Sparrow)item).Name = "Sparrow";
                    Console.WriteLine(((Sparrow)item).Name);

                }
                    


                    
            }



            #endregion


        }
    }
}
