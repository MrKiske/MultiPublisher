using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace DelegatesExample
{
    class Program
    {

        private delegate void CallMethod();

        static void Main(string[] args)
        {
            Console.WriteLine($"Time execution for Method1: {MeasureExecutionTime(Method1)} ms.");
            Console.WriteLine($"Time execution for Method2: {MeasureExecutionTime(Method2)} ms.");
            Console.WriteLine($"Time execution for Method3: {MeasureExecutionTime(Method3)} ms.");

            Console.ReadLine();
        }

        private static void Method1()
        {
          
            var number = new Random().Next(500, 2999);
            Thread.Sleep(number);
           
        }

        private static void Method2() 
        {
            var number = new Random().Next(3000, 5999);
            Thread.Sleep(number);
        }

        private static void Method3()
        {
            var number = new Random().Next(6000, 9999);
            Thread.Sleep(number);
        }

        private static double MeasureExecutionTime(CallMethod methodToExecute)
        {
            var dateStart = DateTime.Now;
            methodToExecute();
            var dateEnd = DateTime.Now;
            return (dateEnd - dateStart).Milliseconds;
        }
    }
}
