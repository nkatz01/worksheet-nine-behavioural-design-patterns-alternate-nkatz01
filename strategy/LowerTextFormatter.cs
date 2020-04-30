using System;

namespace strategy
{
    public class LowerTextFormatter : ITextFormatter
    {
        public void Format(string text)
        {
            Console.WriteLine($"{this.GetType().Name}: {text.ToLower()}");
        }
    }
}