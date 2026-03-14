using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public class Dog : Mammal
    {
        private string breed;


        public string Breed
        {
            get => breed;
            set
            {
                breed = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()};Breed: {Breed}";
        }
    }
}