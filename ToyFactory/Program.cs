using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ToyFactory.Generics;
using ToyFactory.Interfaces;
using ToyFactory.Toys;

namespace ToyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory<Doll> factory = new DollFactory();
            var boxes = BoxHelper.GenerateBoxes<Doll>(50, factory.MakeElement);

            Parallel.ForEach(boxes, b=>
                {
                    Console.WriteLine(b.ToString());
             });
        }
    }
}
