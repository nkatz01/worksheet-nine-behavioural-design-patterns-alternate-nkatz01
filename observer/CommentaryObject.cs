using System;
using System.Collections.Generic;

namespace observer
{
    public class CommentaryObject : ISubject, ICommentary
    {
        public CommentaryObject(List<IObserver> observers, string s)
        {
            throw new System.NotImplementedException();
        }

        public void SubscribeObserver(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void UnSubscribeObserver(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new System.NotImplementedException();
        }

        public string SubjectDetails()
        {
            throw new System.NotImplementedException();
        }

        public string Description { get; set; }
    }
}