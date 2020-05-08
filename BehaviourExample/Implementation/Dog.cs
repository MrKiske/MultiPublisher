using BehaviourExample.Interfaces;
using System;

namespace BehaviourExample.Implementation
{
    public class Dog : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("I will play with ball");
        }
    }
}
