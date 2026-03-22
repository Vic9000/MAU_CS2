using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
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

        public override int GetAverageLifeSpan()
        {
            return 13; // An average lifespan for a dog
        }

        public override void SetSleepTime()
        {
            sleepTime = 12; // Dogs sleep about 12-14 hours a day
        }

        public override string ToStringSummary()
        {
            return base.ToStringSummary() + $"{Breed}";
        }

        public override string ToString()
        {
            return $"{base.ToString()};Breed: {Breed}";
        }
    }
}