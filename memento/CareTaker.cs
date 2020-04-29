using System;
using System.Collections.Generic;

namespace worksheet_nine_behavioural_design_patterns
{
    public class CareTaker
    {
        private Dictionary<string, Memento> _savepointStorage = new Dictionary<string, Memento>();

        public void SaveMemento(Memento memento, string savepointName)
        {

            _savepointStorage.Add(savepointName, memento);
        }

        public Memento Memento(string savepointName) {

            Memento memento; 
            _savepointStorage.TryGetValue(savepointName, out memento);
            return memento;  
        }

        public void ClearSavePoints()
        {
            _savepointStorage.Clear();
            Console.WriteLine("Clearing all save points...");
        }
    }
}