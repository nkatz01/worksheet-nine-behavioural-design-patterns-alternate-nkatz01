using System.Collections.Generic;

namespace worksheet_nine_behavioural_design_patterns
{
    public class CareTaker
    {
        private Dictionary<string, Memento> _savepointStorage = new Dictionary<string, Memento>();

        public void SaveMemento(Memento memento, string savepointName) => throw new System.NotImplementedException();

        public Memento Memento(string savepointName) => throw new System.NotImplementedException();

        public void ClearSavePoints() => throw new System.NotImplementedException();
    }
}