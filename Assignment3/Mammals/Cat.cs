using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
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
            return 15;
        }

        public override string ToString()
        {
            string mammalInfo = base.ToString();

            return $"{mammalInfo}, Fur Type: {FurType}";
        }

        public override string ToTextString()
        {
            string baseData = base.ToTextString();
            return $"{baseData},{furType}";
        }
    }
}