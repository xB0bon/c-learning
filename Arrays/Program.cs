namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "BMW", "AUDI", "TESLA", "FORD" };
            // metoda 1
            /*
            

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            */
            //metoda 2
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
};