using System;
using System.ComponentModel.DataAnnotations;

namespace worksheet_nine_behavioural_design_patterns
{
    public class Originator
    {
        private readonly CareTaker CareTaker;
        private string _lastUndoSavepoint;
        public double X { get; set; }
        public double Y { get; set; }

        public Originator(double x, double y, CareTaker careTaker)
        {
            X = x;
            Y = y;
          CareTaker = careTaker;
            CreateSavepoint("INITIAL");

        }

        public void CreateSavepoint(string savepointName)
        {
            Console.WriteLine($"Saving state... {savepointName}");
          CareTaker.SaveMemento(new Memento(this.X, this.Y), savepointName);
            _lastUndoSavepoint = savepointName;
        }

        public void Undo()
        {
         Undo(_lastUndoSavepoint);
            
        }

        public void Undo(string savepointName)
        {
            Console.WriteLine($"Undo at... {savepointName}");
            Memento memento = CareTaker.Memento(savepointName);
            this.X = memento.X; 
            this.Y = memento.Y;
           
        }

        public void UndoAll()
        {
             Undo("INITIAL");
            CareTaker.ClearSavePoints();
            CreateSavepoint("INITIAL");


        }

        private void OriginatorState(string savepointName)
        {
          var m =  CareTaker.Memento(savepointName);
            Console.WriteLine($"At savepoint {savepointName} the state of X was {m.X} and Y was {m.Y}");
        }

        public override string ToString() => $"X: {X}, Y: {Y}";

       
    }
}