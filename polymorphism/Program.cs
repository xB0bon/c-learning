using System.Reflection.Metadata;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat =new Boat();

            Vechicle[] vechicles = { car, bicycle, boat };

            foreach (Vechicle vech in vechicles)
            {
                vech.Go();
            }

        }

        class Vechicle
        {
            public virtual void Go()
            {
                
            }
        }

        class Car : Vechicle
        {
            public override void Go()
            {
                Console.WriteLine("|car is running|");
            }
        }
        class Bicycle : Vechicle
        {
            public override void Go()
            {
                Console.WriteLine("|bicycle is running|");
            }
        }
        class Boat : Vechicle
        {
            public override void Go()
            {
                Console.WriteLine("|boat is running|");
            }
        }


        

    }

    
    
    

    

    
};