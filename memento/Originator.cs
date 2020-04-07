using System;
using System.ComponentModel.DataAnnotations;

namespace worksheet_nine_behavioural_design_patterns
{
    public class Originator
    {
        private string _lastUndoSavepoint;
        public double X { get; set; }
        public double Y { get; set; }

        public Originator(double x, double y, CareTaker careTaker)
        {
            CreateSavePoint("INITIAL");
            throw new System.NotImplementedException();
        }

        public void CreateSavePoint(string savepointName)
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }

        public void Undo(string savepointName)
        {
        }

        public void UndoAll()
        {
        }

        private void OriginatorState(string savepointName)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => $"X: {X}, Y: {Y}";

        public void CreateSavepoint(string save1)
        {
            throw new NotImplementedException();
        }
    }
}