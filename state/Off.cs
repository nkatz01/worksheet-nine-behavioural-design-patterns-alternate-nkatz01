using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    class OffState : RoboticState
    {

        public override void Walk()
        {
            Off();
            Console.WriteLine("Walking...");

        }

        public override void Cook()
        {

            Console.WriteLine("Cannot cook at Off state.");

        }

        public override void Off()
        {
            this.Robot.TransitionTo(new OnState());
            Console.WriteLine("Robot is switched On");
            
        }
    }
}
