using ExplicitImplementation.Class;
using ExplicitImplementation.Interfaces;
using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var player = person as IPlayer;
            var musician = person as IMusician;

            person.Play();
            player.Play();
            musician.Play();

            Console.ReadLine();
        }
    }
}
