using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public abstract class Mammal : Animal
    {
        private int numOfTeeth;
        private double tailLength;

        public int NumOfTeeth
        {
            get { return numOfTeeth; }
            set { numOfTeeth = value; }
        }

        public double TailLength
        {
            get { return tailLength; } 
            set { tailLength = value; }
        }

        public override string ToString()
        {
            return $"Number of Teeth: {numOfTeeth}, Tail Length: {tailLength}";
        }

        public override string ToTextString()
        {
            string baseData = base.ToTextString();
            return $"{baseData},{numOfTeeth},{tailLength}";
        }
    }
}