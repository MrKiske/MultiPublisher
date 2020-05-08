using FruitOrchard.Base;
using FruitOrchard.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitOrchard.Extensions
{
    public static class BoxExtensions
    {
        public static void FillBox<T>(this Box<T> box, FruitTree<T> tree) where T: Fruit, new()
        {
            do
            {
                try
                {
                    box.Add(tree.CreateFruit());
                }
                catch (Exception)
                {
                    break;
                }
            } while (true);
        }
    }
}
