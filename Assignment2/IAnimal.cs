using Assignment1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal interface IAnimal
    {
        string Name { get; set; }
        double Age { get; set; }
        GenderType Gender { get; set; }

        string ToStringSummary();

        void SetSleepTime();
        int GetAverageLifeSpan();
    }
}
