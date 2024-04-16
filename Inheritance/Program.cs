using System.Reflection.Metadata;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat bout = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bout.speed);

            car.Start();
            bicycle.Start();
            bout.Start();

        }

    }

    class Vehicles()
    {
        public int speed;

        public void Start()
        {
            Console.WriteLine("This vehicle is running!");
        }
    }
    
    class Car : Vehicles
    {
        public int wheels = 4;

    }
    class Bicycle : Vehicles
    {
        public int wheels = 2;

    }
    class Boat : Vehicles
    {
        public int wheels = 0;

    }

    

    
};