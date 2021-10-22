using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Cat : Animal
    {
        public Cat() : base()
        {
            Price = 6500m;

            //Mice killed randomly
            Random r = new();
            MiceKilled = r.Next(0, 29);
            Breed = (CatBreed)r.Next(0, Enum.GetNames(typeof(CatBreed)).Length);
            Siblings = r.Next(1, 6);

            SetPrice();
        }

        public CatBreed Breed { get; private set; }

        public int MiceKilled { get; private set; }

        public int Siblings { get; private set; }

        public override string ToString() => $"CAT \n{Age} year{(Age == 1 ? "" : "s")} old \n{PriceString}\nThis cat... \n\tis a {Utilities.ReplaceeUnderlineWithSpaceString(Breed.ToString())}\n\thas killed {MiceKilled} {(MiceKilled == 1 ? "mouse" : "mice")}\n\thas {Siblings} sibling{(Siblings > 1 ? "s" : "")}.";

        protected override void SetPrice()
        {

            CalculateAgePrice();

            //If 1 sibling only more expensive.
            if (Siblings < 2)
                Price *= 1.2m;

            //If killed a lot of mice more expensive
            if (MiceKilled > 21)
                Price *= 1.7m;


        }
    }
}