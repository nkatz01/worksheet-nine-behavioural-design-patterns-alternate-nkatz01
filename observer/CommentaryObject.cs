using System;
using System.Collections.Generic;

namespace observer
{

    public class CommentaryObject : ISubject, ICommentary
    {
        private List<IObserver> Observers { get; set; }

        public CommentaryObject(List<IObserver> observers, string s)
        {

            //   subjectDetails = s;
            SubjectDetails = s;
            Observers = observers;
        }

        public void SubscribeObserver(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Subscribed successfully.");
        }

        public void UnSubscribeObserver(IObserver observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
            Console.WriteLine("Unsubscribed successfully.");

        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in Observers) {
                obs.Update(Description);
            };
        }

        //public string SubjectDetails()
        //{
        //    return subjectDetails;
        //}

        public string Description
        {
            set
            {

                description = value;
                NotifyObservers();
            }
            get
            {
                return description;
            }
        }
        public string SubjectDetails { get; }

        private string description;

     
    }
}