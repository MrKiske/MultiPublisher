using ExplicitImplementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitImplementation.Class
{
    public class Person : IPlayer, IMusician
    {
         void IPlayer.Play()
        {
            Console.WriteLine("I will videoplay games.");
        }

         void IMusician.Play()
        {
            Console.WriteLine("I will play the piano.");
        }

        public void Play()
        {
            Console.WriteLine("I don't know if I play the piano or I videoplay games.");
        }
    }
}
