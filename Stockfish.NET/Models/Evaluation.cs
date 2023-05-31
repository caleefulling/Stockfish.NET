using System;

namespace Stockfish.NET.Models
{
    [Serializable]
    public class Evaluation
    {
        public string Type { get; set; }
        public int Value { get; set; }

        public Evaluation()
        {
        }

        public Evaluation(string type, int value)
        {
            Type = type;
            Value = value;
        }
    }
}