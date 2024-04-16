namespace multidimensionalarrays
{
    class Program
    {
        static void Main(string[] args)
        {

            String[,] cars =
            {
                { "ford", "Mustang", "Camaro" },
                { "Corvette", "Silverado", "Camry" },
                { "F-150", "Corrola", "Explorer" }
            };
            //Console.WriteLine(cars[1, 1]); // silverado
            cars[1, 1] = "Audi A5";
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }


    }

};