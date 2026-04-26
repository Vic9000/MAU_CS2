using Assignment3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment3
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

        /// <summary>
        /// Uses LINQ to find all animals older than a specified age.
        /// </summary>
        public List<Animal> GetAnimalsOlderThan(double ageLimit)
        {
            return m_list.Where(animal => animal.Age > ageLimit).ToList();
        }

        /// <summary>
        /// Uses LINQ to return a new list of animals sorted alphabetically by their Name.
        /// </summary>
        public List<Animal> SortAnimalsByName()
        {
            return m_list.OrderBy(animal => animal.Name).ToList();
        }

        /// <summary>
        /// Uses LINQ to extract only the Dogs from the general animal list.
        /// </summary>
        public List<Animal> GetAllDogs()
        {
            // .Cast<Animal>() converts the dogs back into generic animals for the output list
            return m_list.OfType<Dog>().Cast<Animal>().ToList();
        }

        /// <summary>
        /// Uses LINQ to extract only the Cats from the general animal list.
        /// </summary>
        public List<Animal> GetAllCats()
        {
            return m_list.OfType<Cat>().Cast<Animal>().ToList();
        }

        /// <summary>
        /// Uses LINQ to extract only the Turtles from the general animal list.
        /// </summary>
        public List<Animal> GetAllTurtles()
        {
            return m_list.OfType<Turtle>().Cast<Animal>().ToList();
        }

        /// <summary>
        /// Uses LINQ to extract only the Lizards from the general animal list.
        /// </summary>
        public List<Animal> GetAllLizards()
        {
            return m_list.OfType<Lizard>().Cast<Animal>().ToList();
        }

        public override void LoadFromText(string fileName)
        {
            DeleteAll();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 7)
                    {
                        string category = data[0];
                        string species = data[1];
                        string id = data[2]; 
                        string name = data[3];
                        double age = double.Parse(data[4]);
                        double weight = double.Parse(data[5]);
                        GenderType gender = Enum.Parse<GenderType>(data[6]);

                        Animal newAnimal = null;

                        switch (species)
                        {
                            case "Dog":
                                Dog dog = new Dog();
                                dog.NumOfTeeth = int.Parse(data[7]); 
                                dog.TailLength = double.Parse(data[8]); 
                                dog.Breed = data[9]; 
                                newAnimal = dog;
                                break;

                            case "Cat":
                                Cat cat = new Cat();
                                cat.NumOfTeeth = int.Parse(data[7]);
                                cat.TailLength = double.Parse(data[8]);
                                cat.FurType = Enum.Parse<FurType>(data[9]);
                                newAnimal = cat;
                                break;

                            case "Turtle":
                                Turtle turtle = new Turtle();
                                turtle.BodyLength = double.Parse(data[7]);
                                turtle.LivesInWater = bool.Parse(data[8]);
                                turtle.ShellWidth = double.Parse(data[9]);
                                newAnimal = turtle;
                                break;

                            case "Lizard":
                                Lizard lizard = new Lizard();
                                lizard.BodyLength = double.Parse(data[7]);
                                lizard.LivesInWater = bool.Parse(data[8]);
                                lizard.TailLength = double.Parse(data[9]);
                                newAnimal = lizard;
                                break;
                        }

                        if (newAnimal != null)
                        {
                            newAnimal.Id = id; 
                            newAnimal.Name = name;
                            newAnimal.Age = age;
                            newAnimal.Weight = weight;
                            newAnimal.Gender = gender;

                            Add(newAnimal);
                        }
                    }
                }
            }
        }
    }
}
