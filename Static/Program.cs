using System.Reflection.Metadata;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Car fordmustang = new Car("Ford", "Mustang", 2024, "black");
            Car AudiA5 = new Car("Audi", "A5", 2022, "red");
            Car Lamborgini = new Car("Lamborgini", "Adevntador", 2021, "yellow");
            fordmustang.Drive();
            AudiA5.Drive();
            Lamborgini.Drive();
            Console.WriteLine(Car.NumberOfCars);
        }
        


    }

    class Car
    { 
        String? make;
        String? model; 
        int year;
        String? color;
        public static int NumberOfCars;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"{make} {model} {color} {year} is Driving");

        }
    }

    
};