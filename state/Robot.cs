using System;

namespace state
{
    public class Robot  
    {
        private IRoboticState _state; 
        private enum State
        {
            On,
            Cook,
            Walk,
            Off
        };


        public void TransitionTo(IRoboticState state)
        {

            this._state = state;
            this._state.SetContext(this);
        }

        private State RoboticState { get; set; }

        public Robot() {

            TransitionTo(new OnState());

        }

        public void Walk()
        {
            TransitionTo(new OnState());
            _state.Walk();
        }

        public void Cook()
        {
            _state.Cook();
        }

        public void Off()
        {
            _state.Off();
        }

        public void On()
        {
            _state.Off();
        }

        //private bool OkayToProceed(string state)
        //{
        //    bool flag = true;
        //    if (RoboticState == State.Off)
        //    {
        //        Console.WriteLine($"Cannot {state} at Off state.");
        //        flag = false;
        //    }

        //    return flag;
        //}
    }
}