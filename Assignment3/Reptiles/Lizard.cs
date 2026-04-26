using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class Lizard : Reptile
    {
        private double tailLength;
        public double TailLength
        {
            get => tailLength;
            set
            {
                tailLength = value;
            }
        }

        public override int GetAverageLifeSpan()
        {
            return 10; 
        }

        public override string ToString()
        {
            string reptileInfo = base.ToString();

            return $"{reptileInfo}, Tail Length: {TailLength}";
        }

        public override string ToTextString()
        {
            string baseData = base.ToTextString();
            return $"{baseData},{tailLength}";
        }
    }
}