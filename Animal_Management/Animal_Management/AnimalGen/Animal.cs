using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management
{
    public class Animal
    {
        // Fields
        private CategoryType category;
        private GenderType gender;
        private string name;
        private int id;
        private int age;
        private decimal weight;

        // Constructor
        public Animal()
        {
            name = "Unknown";
            gender = GenderType.Unknown;
        }

        // Properties
        public CategoryType Category
        {
            get { return category; } 
            set { category = value; }
        }

        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value >= 0) 
                    age = value; 
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set 
            {
                if (value >= 0) 
                    weight = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {id,-5} Name: {name,-15} Age: {age,-5} Gender: {gender,-10} Weight: {weight,-8}";
        }
    }
}
