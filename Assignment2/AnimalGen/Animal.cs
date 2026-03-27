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

        public string ToStringSummary()
        {
            string name = string.IsNullOrEmpty(Name) ? "Unknown" : Name.Substring(0, Math.Min(12, Name.Length));
            string species = this.GetType().Name;

            return $"{Id,-5} {species,-8} {name,-14} {Age,-7} {Weight,-7} {Gender}";
        }
    }
}
