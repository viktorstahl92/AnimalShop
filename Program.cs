using System;

namespace AnimalShop
{


    class Program
    {
        static void Main(string[] args)
        {
            MenuLoop();
        }

        private static void MenuLoop()
        {
            AnimalShop myShop = new();
            bool done = false;
            do
            {
                Console.Clear();
                ShowBasicInfo(myShop);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Sell an animal");
                Console.WriteLine("2. List all sold animals");
                Console.WriteLine("3. List all sold animals sorted by price");
                Console.WriteLine("9. Exit the program");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        SellAnAnimal(ref myShop);
                        break;
                    case '2':
                        ListAllAnimals(myShop);
                        break;
                    case '3':
                        ListAllAnimalsByPrice(myShop);
                        break;
                    case '9':
                        done = true;
                        break;
                }

            } while (!done);
        }

        private static void ListAllAnimalsByPrice(AnimalShop myShop)
        {
            Console.WriteLine("\n\nYou've sold these animals:");
            Console.WriteLine(myShop.ListAllSoldAnimalsSortedAsString);
            ClickAnyKeyToContinue();
        }

        private static void ListAllAnimals(AnimalShop myShop)
        {
            Console.WriteLine("\n\nYou've sold these animals:");
            Console.WriteLine(myShop.ListAllSoldAnimalsAsString);
            ClickAnyKeyToContinue();
        }

        private static void SellAnAnimal(ref AnimalShop myShop)
        {
            Animal soldAnimal;
            do
            {
                Console.WriteLine("\n\nType the animal type that got sold: ");
                Console.Write("\t");
                soldAnimal = myShop.SellAnimal(Console.ReadLine());

                if (soldAnimal == null)
                    Console.WriteLine("Error in input. Please try again! (Try Tiger, Cat or Dog - We don't have too much in stock as of now)");

            } while (soldAnimal == null);
            Console.WriteLine("\n\nYou sold:");
            Console.WriteLine(soldAnimal.ToString());
            ClickAnyKeyToContinue();
        }

        private static void ClickAnyKeyToContinue()
        {
            Console.WriteLine("\nClick any key to continue!");
            Console.ReadKey();
        }

        private static void ShowBasicInfo(AnimalShop myShop) => Console.WriteLine(myShop);
    }
}
