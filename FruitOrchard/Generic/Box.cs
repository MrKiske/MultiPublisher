using FruitOrchard.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitOrchard.Generic
{
    public class Box<T> : IEnumerable<T> where T : IWeighable
    {

        private readonly List<T> ListContent = new List<T>();

        public int MaxWeight { get; private set; }

        public Box(int maxWeight)
        {
            this.MaxWeight = maxWeight;
            ListContent = new List<T>();
        }

        private bool CanAdd(int weight)
        {
            return ListContent.Sum(i => i.Weight) + weight <= MaxWeight;
        }

        public void Add(T item)
        {
            if (ListContent.Contains(item))
            {
                throw new Exception("Element already exist in the box.");
            }

            if (!CanAdd(item.Weight))
            {
                throw new Exception("Max weight has gone to the limit.");
            }

            ListContent.Add(item);
        }
        public IEnumerator<T> GetEnumerator()=> ListContent.GetEnumerator();

        public bool Remove(T item)
        {
            return ListContent.Remove(item);
        }

        public T this[int i] => ListContent[i];

        IEnumerator IEnumerable.GetEnumerator() => ListContent.GetEnumerator();
    }
}
