using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class Turtle : Reptile
    {
        private double shellWidth;
        public double ShellWidth
        {
            get => shellWidth;
            set
            {
                shellWidth = value;
            }
        }
        public override int GetAverageLifeSpan()
        {
            return 100;
        }

        public override string ToString()
        {
            string reptileInfo = base.ToString();

            return $"{reptileInfo}, Shell Width: {ShellWidth}";
        }

        public override string ToTextString()
        {
            string baseData = base.ToTextString();
            return $"{baseData},{shellWidth}";
        }
    }
}