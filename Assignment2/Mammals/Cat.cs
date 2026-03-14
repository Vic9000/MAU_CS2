using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class Cat : Mammal
    {
        private FurType furType;
        public FurType FurType
        {
            get => furType;
            set
            {
                furType = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()};Fur Type: {FurType}";
        }
    }
}