using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class Tiger : Animal
    {
        public Tiger()
        {
            Price = 19500m;

            //Get random values.
            Random r = new();


            NumberOfStripes = r.Next(94, 102);
            ScaredHumans = r.Next(0, 12);

            SetPrice();
        }
        public int NumberOfStripes { get; private set; }

        public int ScaredHumans { get; private set; }

        public bool Dangerous => ScaredHumans > 5;

        public override string ToString() => $"TIGER\n{Age} year{(Age == 1 ? "" : "s")}\n{PriceString}\nThis tiger... \n\t{(Dangerous ? "IS CONSIDERED DANGEROUS" : "is not considered dangerous")}\n\thas {NumberOfStripes} stripes.\n\thas scared {ScaredHumans} humans.";

        protected override void SetPrice()
        {
            CalculateAgePrice();

            //If dangerous much more expensive.
            if (Dangerous)
                Price *= 4;


        }
    }
}