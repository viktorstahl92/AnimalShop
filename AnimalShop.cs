using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public class AnimalShop
    {

        #region Properties
        private decimal Money { get; set; }

        private List<Animal> SoldAnimals { get; set; }

        public string ListAllSoldAnimalsAsString => ReturnListAsFormattedString(SoldAnimals);

        public string ListAllSoldAnimalsSortedAsString
        {
            get
            {
                List<Animal> SortedList = new List<Animal>(SoldAnimals.OrderByDescending(n => n.Price));
                return ReturnListAsFormattedString(SortedList);
            }
        }


        #endregion

        public AnimalShop() => SoldAnimals = new();

        public Animal SellAnimal(string animalType)
        {
            Animal newAnimal;

            switch (animalType.ToUpper().Trim())
            {
                case "DOG":
                    newAnimal = new Dog();
                    break;
                case "CAT":
                    newAnimal = new Cat();
                    break;
                case "TIGER":
                    newAnimal = new Tiger();
                    break;
                default:
                    return null;
            }

            Money += newAnimal.Price;
            SoldAnimals.Add(newAnimal);
            return newAnimal;
        }

        private string ReturnListAsFormattedString(List<Animal> SortedList)
        {
            if (SortedList.Count == 0)
                return "No animals sold";

            string stringToReturn = "";
            for (int i = 0; i < SortedList.Count; i++)
            {

                stringToReturn += ($"\nANIMAL {i + 1}\n");
                stringToReturn += $"{SortedList[i]}\n";
            }

            return stringToReturn;
        }

        public override string ToString() => $"Welcome to\nYOUR FANTASTICAL ANIMAL SHOP!\n\tMoney: {string.Format("{0:C}", Money)}";
    }
}