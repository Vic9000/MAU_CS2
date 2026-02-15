using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management
{
    public class Cat : Mammal
    {
        private HairType hairType;
        private CatBreed breed;

        public Cat() : base()
        {
            hairType = HairType.Short;
            breed = CatBreed.Unknown;
        }

        public HairType HairType
        {
            get { return hairType; }
            set { hairType = value; }
        }

        public CatBreed Breed
        {
            get { return breed; }
            set { breed = value; }
        }

    }
}
