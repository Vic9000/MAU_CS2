using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    public class Cat : Mammal
    {
        private FurType furType;

        public FurType FurType
        {
            get => furType;
            set { furType = value; }
        }

        public override int GetAverageLifeSpan()
        {
            return 15; // An average lifespan for an indoor cat
        }

        public override string ToStringSummary()
        {
            return base.ToStringSummary() + $"   Cat, Fur: {FurType.ToString()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()};Fur Type: {FurType}";
        }
    }
}