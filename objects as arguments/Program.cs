using System.Reflection.Metadata;

namespace objects_as_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("red", "Mustang");
            car1.test();
            ChangeColor(car1, "silver");
            car1.test();                           

        }

        static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

    }

    class Car
    {
        public String color;
        public String model;

        public Car(String color, String model)
        {
            this.color = color;
            this.model = model;
        }

        public void test()
        {
            Console.WriteLine($"{model} is {color}");
        }

    }
    
    

    

    
};