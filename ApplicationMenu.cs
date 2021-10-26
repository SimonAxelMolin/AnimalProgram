using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProgram
{
    class ApplicationMenu
    {
        string menuAnswer;
        string moreInfo;

        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myBird = new Bird();
        Animal mySnake = new Snake();
        Animal myOtter = new Otter();

        public void Menu()
        {
            Console.WriteLine("Welcome to the Animal Information program.");
            Console.WriteLine();
            Console.WriteLine("Please type: Dog, Bird, Snake, Otter or Animals for more information about animals.");

            AnimalCase();
        }

        public void AnimalCase()
        {
            menuAnswer = Console.ReadLine();

            switch (menuAnswer)
            {
                case "Dog":
                case "dog":
                    Console.Clear();
                    myDog.Legality();
                    break;

                case "Bird":
                case "bird":
                    Console.Clear();
                    myBird.Legality();
                    break;

                case "Snake":
                case "snake":
                    Console.Clear();
                    mySnake.Legality();
                    break;

                case "Otter":
                case "otter":
                    Console.Clear();
                    myOtter.Legality();
                    break;
                    
                case "Animals":
                case "animals":
                    Console.Clear();
                    myAnimal.Legality();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Reply with one of the following animals: Dog, Bird, Snake, Otter or Animals");
                    AnimalCase();
                    break;
            }

                Console.WriteLine("Would you like to get information about any other animals? y/n");
                getMoreInfo();  
        }

        public void EndProgram()
        {
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void getMoreInfo()
        {
            moreInfo = Console.ReadLine();

            if (moreInfo == "y")
            {
                Console.Clear();
                Console.WriteLine("Please Reply with one of the following animals: Dog, Bird, Snake, Otter or Animals");
                Console.WriteLine();
                AnimalCase();
            }
            else if (moreInfo == "n")
            {
                Console.Clear();
                EndProgram();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please answer with y/n.");
                getMoreInfo();
            }
        }
    }
}
