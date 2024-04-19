using System.Reflection.Metadata;

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
               Animal animal = new Animal();
               Dog dog = new Dog();
               Cat cat = new Cat();
               
               animal.Speak();
               dog.Speak(); 
               cat.Speak();

        }

        

    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speak *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speak *woof woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speak *meow meow*");
        }
    }

    

    
};