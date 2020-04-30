using System;

namespace strategy
{
    public class CapTextFormatter : ITextFormatter
    {
        public void Format(string text)
        {
           Console.WriteLine($"{this.GetType().Name}: {text.ToUpper()}");
        }
    }
}