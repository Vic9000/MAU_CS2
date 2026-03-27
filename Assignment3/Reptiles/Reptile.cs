using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public abstract class Reptile : Animal
    {
        private double bodyLength;
        private bool livesInWater;
        public double BodyLength
        {
            get { return bodyLength; }
            set { bodyLength = value; }
        }

        public bool LivesInWater
        {
            get { return livesInWater; }
            set { livesInWater = value; }
        }

        public override string ToString()
        {
            string waterInfo = LivesInWater ? "Yes" : "No";
            return $"Body Length: {BodyLength}, Lives in Water: {waterInfo}";
        }
    }
}