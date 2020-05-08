using System;
using System.Timers;

namespace TimerEventExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var timer = new Timer { Interval = 3000 };
            timer.Elapsed += (sender, e) => Console.WriteLine("The timer has been execute!.");
            timer.Start();
            Console.ReadLine();
        }
    }
}
