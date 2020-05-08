using PhoneBook.Class;
using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entry> listEntries = new List<Entry>()
          {
            new Entry { Name = "Pete", LastName = "Avendano" },
            new Entry { Name = "Carolina", LastName = "Vargas" },
            new Entry { Name = "Leonor", LastName = "Beltran" },
            new Entry { Name = "Mario", LastName = "Avendano" },
            new Entry { Name = "SimonPelitos", LastName = "Gaticos" }
          };

           
            //Anonimous Method
            listEntries.Sort(delegate (Entry entry1, Entry entry2) {
                return $"{entry1.Name} {entry1.LastName}".CompareTo($"{entry2.Name} {entry2.LastName}");
            });

            //Lambda Expression
            listEntries.Sort((entry1, entry2) => $"{entry1.Name} {entry1.LastName}".CompareTo($"{entry2.Name} {entry2.LastName}"));

            foreach (var entry in listEntries)
            {
                Console.WriteLine($"{entry.Name} - {entry.LastName}");
            }

            Console.ReadLine();
        }
    }
}
