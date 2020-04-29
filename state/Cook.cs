using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    class CookingState : RoboticState
    {

        public override void Walk()
        {
            
            Console.WriteLine("Walking...");

        }

        public override void Cook()
        {
            Console.WriteLine("Cooking...");
           

        }

        public override void Off()
        {

            Console.WriteLine("Cannot switch off in cooking state");
            
        }
    }
}
