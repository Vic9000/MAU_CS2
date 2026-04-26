using Assignment3;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Text.Json.Serialization;

namespace Assignment3
{
    [JsonDerivedType(typeof(Dog), typeDiscriminator: "Dog")]
    [JsonDerivedType(typeof(Cat), typeDiscriminator: "Cat")]
    [JsonDerivedType(typeof(Turtle), typeDiscriminator: "Turtle")]
    [JsonDerivedType(typeof(Lizard), typeDiscriminator: "Lizard")]
    public class Animal : IAnimal
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

        public virtual int GetAverageLifeSpan()
        {
            return 10;
        }

        public string ToStringSummary()
        {
            string name = string.IsNullOrEmpty(Name) ? "Unknown" : Name.Substring(0, Math.Min(12, Name.Length));
            string species = this.GetType().Name;

            return $"{Id,-5} {species,-8} {name,-14} {Age,-7} {Weight,-7} {Gender}";
        }

        public virtual string ToTextString()
        {
            return $"{this.GetType().BaseType.Name},{this.GetType().Name},{Id},{Name},{Age},{Weight},{Gender}";
        }
    }
}
