using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class Reptile : Animal
    {
        private double bodyLength;
        private bool livesInWater;
        public double BodyLength
        {
            get => bodyLength;
            set
            {
                bodyLength = value;
            }
        }

        public bool LivesInWater
        {
            get => livesInWater;
            set
            {
                livesInWater = value;
            }
        }

        public override string ToString()
        {
            string waterInfo = LivesInWater ? "Yes" : "No";
            return $"{base.ToString()};Body Length: {BodyLength};Lives in Water: {waterInfo}";
        }
    }
}