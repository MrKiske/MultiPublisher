using BehaviourExample.Interfaces;
using System;

namespace BehaviourExample.Implementation
{
    public class Persona : IDriver, IPlayer
    {
        public void Drive()
        {
            Console.WriteLine("Ready for drive!");
        }

        public void Play()
        {
            Console.WriteLine("Ready for play!");
        }
    }
}
