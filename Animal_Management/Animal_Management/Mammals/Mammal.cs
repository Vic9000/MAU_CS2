using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management
{
    public class Mammal : Animal
    {
        // Fields
        private int numOfTeeth;
        private double tailLength;

        // Constructor
        public Mammal() : base()
        {

        }

        public int NumOfTeeth
        {
            get { return numOfTeeth; }
            set
            {
                if (value >= 0)
                    numOfTeeth = value;
            }
        }

        public double TailLength
        {
            get { return tailLength; }
            set
            {
                if (value >= 0)
                    tailLength = value;
            }
        }

        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo} | Teeth: {numOfTeeth,-3} Tail: {tailLength:F1} cm";
        }
    }
}
