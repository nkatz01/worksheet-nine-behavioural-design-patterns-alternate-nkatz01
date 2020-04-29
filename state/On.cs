using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
  public   class OnState : RoboticState
    {

        public override void Walk()
        {
            
            Console.WriteLine("Walking...");
          
        }

        public override void Cook()
        {
           
            Console.WriteLine("Cooking...");
            this.Robot.TransitionTo(new CookingState());
        }

        public override void Off()
        {
            
           
            this.Robot.TransitionTo(new OffState());
            Console.WriteLine("Robot is switched off");
        }

    }
}
