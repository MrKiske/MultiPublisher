using FruitOrchard.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitOrchard.Generic
{
    public class FruitTree<T> where T: Fruit,  new ()
    {
        public T CreateFruit() {

            var rnd = new Random(DateTime.Now.Millisecond);
            return new T { Weight = rnd.Next(180, 3001) };
        }
    }
}
