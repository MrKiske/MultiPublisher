using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericNetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListNames = new List<string> { "Hugo","Paco","Luis" };
            ListNames.Add("Ana");
            ListNames.RemoveAt(0);
            ListNames.Insert(0, "Ramiro");


            var DictionaryExample = new Dictionary<string, int> { { "Hugo", 1985 }, { "Paco", 1984 }, { "Luis", 1986 } };

            var queue = new Queue<string>();
            queue.Enqueue("message 1");
            queue.Enqueue("message 2");
            queue.Enqueue("message 3");
            queue.Enqueue("message 4");
            queue.Enqueue("message 5");

            bool flag;
            do
            {
                flag = queue.TryDequeue(out var item);
                if (flag)
                {
                    Console.WriteLine(item);
                }
            } while (flag);
        }
    }
}
