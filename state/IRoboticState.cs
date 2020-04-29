namespace state
{
    public interface IRoboticState
    {
        public void SetContext(Robot robot);
        public void Walk();
        public void Cook();
        public void Off();
    }
}