using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public abstract class Mammal : Animal
    {
        private int numOfTeeth;
        private double tailLength;

        public int NumOfTeeth
        {
            get => default;
            set
            {
                numOfTeeth = value;
            }
        }

        public double TailLength
        {
            get => default;
            set
            {
                tailLength = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()};Teeth: {NumOfTeeth};Tail: {TailLength}";
        }
    }
}