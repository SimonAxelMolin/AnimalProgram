using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProgram
{
    class Animal
    {
        public virtual void Legality()
        {
            Console.WriteLine("Sweden allow less animals than other countries to be owned as pets. Majority of animals need a license to be owned.");
            Console.WriteLine();

        }

    }

    class Dog : Animal
    {
        public override void Legality()
        {
            Console.WriteLine("The Dog is an animal that is allowed to be owned in Sweden.");
            Console.WriteLine();
        }

    }

    class Snake : Animal
    {
        public override void Legality()
        {
            Console.WriteLine("Some Snakes are allowed to be owned in Sweden.");
            Console.WriteLine();
        }

    }

    class Bird : Animal
    {
        public override void Legality()
        {
            Console.WriteLine("Some Birds are allowed to be owned in Sweden.");
            Console.WriteLine();
        }

     }

    class Otter : Animal
    {
        public override void Legality()
        {
            Console.WriteLine("The Otter is an animal that is not allowed to be owned in Sweden.");
            Console.WriteLine();
        }
     }
}
