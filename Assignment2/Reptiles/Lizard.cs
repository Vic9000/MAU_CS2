using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
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
        public override string ToString()
        {
            return $"{base.ToString()};Tail Length: {TailLength}";
        }
    }
}