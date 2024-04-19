using System.Reflection.Metadata;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lambo", "Orange", 2020);
            Console.WriteLine(car);
            
        }

        

    }

    class Car
    {
        private String model;
        private String color;
        private int year;

        public Car(String model, String color, int year)
        {
            this.model = model;
            this.color = color;
            this.year = year;
        }
        
        public override string ToString()
        {
            return $"{model} {color} {year}";
        }
    }
    
    

    

    
};