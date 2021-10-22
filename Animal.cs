using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public abstract class Animal
    {

        public Animal()
        {
            Random r = new Random();
            Age = r.Next(0, 14);
        }
        public decimal Price { get; protected set; }

        public int Age { get; set; }

        protected string PriceString => string.Format("{0:C}", Price);

        protected abstract void SetPrice();

        protected void CalculateAgePrice()
        {
            //Age
            decimal ageCalc = (1.0m / (Age + 1));
            Price += Price * ageCalc;
        }
    }
}