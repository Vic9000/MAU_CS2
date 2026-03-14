using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
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
        public override string ToString()
        {
            return $"{base.ToString()};Shell Width: {ShellWidth}";
        }
    }
}