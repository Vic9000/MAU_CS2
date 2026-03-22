using Assignment2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    /// <summary>
    /// Manages a list of Animal objects. Inherits all standard list operations from ListManager.
    /// </summary>
    public class AnimalManager : ListManager<Animal>
    {
        // A simple counter to ensure every animal gets a unique numeric ID
        private int idCounter = 100;

        /// <summary>
        /// Generates a unique ID for a new animal. 
        /// </summary>
        /// <param name="categoryLetter">A letter representing the category (e.g., 'M' for Mammal).</param>
        /// <returns>A formatted ID string (e.g., "M100").</returns>
        public string GetNewID(string categoryLetter)
        {
            // Combine the letter and the counter, then increment the counter for the next animal
            string newId = categoryLetter + idCounter.ToString();
            idCounter++;
            return newId;
        }

        /// <summary>
        /// Creates an array of summary strings for all animals currently in the list.
        /// Used to display the animals in the MainForm's ListBox.
        /// </summary>
        /// <returns>An array of formatted strings.</returns>
        public string[] ToStringSummaryAllAnimals()
        {
            string[] infoStrings = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                Animal currentAnimal = GetAt(i);
                infoStrings[i] = currentAnimal.ToStringSummary();
            }

            return infoStrings;
        }
    }
}
