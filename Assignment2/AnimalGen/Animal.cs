using Assignment1;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace Assignment2
{
    public abstract class Animal : IAnimal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Weight { get; set; }
        public GenderType Gender { get; set; }

        protected int sleepTime = 0;

        public virtual void SetSleepTime()
        {
            sleepTime = 0;
        }

        public abstract int GetAverageLifeSpan();

        public virtual string ToStringSummary()
        {
            string name = Name.Substring(0, Math.Min(12, Name.Length));
            string strOut = $"{Id,-8} {name,-12} {Age,6:f1} {Weight,6:f1} {Gender.ToString()}";
            return strOut;
        }
    }
}
