using Assignment2.AnimalGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2 
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
            return $"{base.ToString()};Teeth: {NumOfTeeth};Tail: {TailLength}";
        }
    }
}