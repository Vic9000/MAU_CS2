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
            // Keep the name length capped at 12 characters to prevent messy columns
            string name = string.IsNullOrEmpty(Name) ? "Unknown" : Name.Substring(0, Math.Min(12, Name.Length));

            // Get the species dynamically based on the actual class type 
            string species = this.GetType().Name;

            string strOut = $"{Id,-8} {species,-10} {name,-12} {Age,5:f1} {Weight,6:f1}   {Gender}";

            return strOut;
        }
    }
}
