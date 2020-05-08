using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFileEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = GetFileLines();
            var i = 0;
            foreach(var line in lines)
            {
                Console.WriteLine(line);
                if (i >= 5)
                    break;
                i++;
            }

            Console.ReadLine();
        }

        private static IEnumerable<string> GetFileLines()
        {
            using (var stream = new FileStream(@"C:\Users\Public\Downloads\file.0.dat", FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line = null;
                    do
                    {
                        line = reader.ReadLine();
                        if(line != null)
                            yield return line;

                    } while (line!= null);
                    yield break;
                }
            }
        }
    }
}
