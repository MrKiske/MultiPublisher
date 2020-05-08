using FruitOrchard.Class;
using FruitOrchard.Extensions;
using FruitOrchard.Generic;
using System;
using System.ComponentModel;
using System.Linq;

namespace FruitOrchard
{
    class Program
    {
        static void Main(string[] args)
        {

            var appleTree = new FruitTree<Apple>();
            var box = new Box<Apple>(40000);
            box.FillBox(appleTree);

            Console.WriteLine($"box has {box.Count()} apples");
            Console.ReadLine();


            //var box = new Box<Apple>(40);
            //var apple = new Apple { Weight = 35 };
            //var otherApple = new Apple { Weight = 35 };
            //box.Add(apple);
            //box.Add(otherApple);

        }
    }
}
