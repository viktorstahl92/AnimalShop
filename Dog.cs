using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Dog : Animal
    {

        public Dog() : base()
        {
            Price = 7000m;
            

            Random r = new();
            IsAdopted = r.Next(2) == 1;
            Breed = (DogBreed)r.Next(0, Enum.GetNames(typeof(DogBreed)).Length);
            WonRaces = r.Next(0, 11);

            SetPrice();
        }

        public DogBreed Breed { get; private set; }

        public bool IsAdopted { get; private set; }

        public int WonRaces { get; private set; }

        public override string ToString() => $"DOG\n{Age} year{(Age == 1 ? "" : "s")} old\n{PriceString}\nThis dog... \n\tis a {Utilities.ReplaceeUnderlineWithSpaceString(Breed.ToString())}\n\thas won {WonRaces} race{(WonRaces > 1 ? "s" : "")} \n\t{(IsAdopted ? "is adopted" : "is not adopted")}";

        protected override void SetPrice()
        {
            CalculateAgePrice();

            //Bigger price if lots of won races.
            if (WonRaces > 7)
                Price *= 2;
        }
    }
}