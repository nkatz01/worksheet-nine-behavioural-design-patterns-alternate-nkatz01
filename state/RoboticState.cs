using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
  public   abstract  class RoboticState : IRoboticState
    {
        protected Robot Robot { get; set; }
        //public  RoboticState(Robot robot)
        //{

        //    Robot = robot; 
        //}

        public void SetContext(Robot robot)
        {
            Robot = robot;
        }

        abstract   public void Walk();
        abstract public void Cook();
        abstract public void Off();

    }
}
