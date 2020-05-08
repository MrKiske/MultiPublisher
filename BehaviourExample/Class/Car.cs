using BehaviourExample.Interfaces;

namespace BehaviourExample.Class
{
    public class Car 
    {
      public IDriver Driver { get; set; }

        public void Start()
        {
            this.Driver.Drive();
        }
    }
}
