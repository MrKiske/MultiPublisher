using System;
using System.Collections.Generic;
using System.Text;
using ToyFactory.Generics;

namespace ToyFactory.Toys
{
    public static class BoxHelper
    {
        public static List<Box<T>> GenerateBoxes<T>(int numberBox, Func<T> getContent)
        {
            var listBoxer = new List<Box<T>>();
            for (int i = 0; i < numberBox; i++)
            {
                var box = new Box<T>();
                box.Put(getContent());
                listBoxer.Add(box);
            }
            return listBoxer;
        }
    }
}
