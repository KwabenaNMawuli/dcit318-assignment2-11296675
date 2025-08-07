using System;

namespace AnimalSounds
{

    //Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    //Derived class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
    //Derived class
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Instantiate objects of the various derived classes

                Animal animal = new Animal();
                Animal dog = new Dog();
                Animal cat = new Cat();

                //Calling the MakeSound methods
                animal.MakeSound();
                dog.MakeSound();
                cat.MakeSound();

            }


        }


    }





}