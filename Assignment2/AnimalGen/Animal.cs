using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment1
{
    public abstract class Animal
    {
        private int age;
        private CategoryType category;
        private string name;
        private GenderType gender;
        private int id;
        private decimal weight;
        private static int idCounter = 100;

        public Animal()
        {
            id = idCounter++;
            name = string.Empty;
            gender = GenderType.Unknown;
        }


        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }

        public CategoryType CategoryType
        {
            get => category;
            set
            {
                category = value;
            }
        }

        public GenderType GenderType
        {
            get => gender;
            set
            {
                gender = value;
            }
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public decimal Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id};Name: {Name};Age: {Age};Gender: {GenderType};Weight: {Weight}";
        }
    }
}