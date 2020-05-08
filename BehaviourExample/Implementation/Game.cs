using BehaviourExample.Interfaces;

namespace BehaviourExample.Implementation
{
    public class Game : IPlayer
    {
       public IPlayer Player { get; set; }

        public void Play()
        {
            this.Player.Play();
        }
    }
}
