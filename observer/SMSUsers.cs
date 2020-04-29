using System;

namespace observer
{
    public class SMSUsers : IObserver
    {
        ISubject Subject { get; set; }
        string Name { get; set; }
        public SMSUsers(ISubject subject, string s)
        {
            Subject = subject;
            Name = s;
        }

        public void Update(string desc)

        {
         
            Console.WriteLine($"{Name}: {desc}") ;
            
        }

        public void Subscribe()
        {
            Console.WriteLine($"Subscribing {Name} to {Subject.SubjectDetails()}");
            Subject.SubscribeObserver(this);   

        }

        public void UnSubscribe()
        {
            Console.WriteLine($"Unsubscribing {Name} to {Subject.SubjectDetails()}");
            Subject.UnSubscribeObserver(this);
        }
    }
}