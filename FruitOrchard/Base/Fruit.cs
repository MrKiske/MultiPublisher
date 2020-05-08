using FruitOrchard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitOrchard.Base
{
    public class Fruit: IWeighable
    {
        public int Weight { get; set; }

        public void GetFruit(string name)
        {
            Console.WriteLine($"I'm  a/an {name}.");
        }
    }
}
