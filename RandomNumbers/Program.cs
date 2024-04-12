namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1, 100);
            //double num1 = random.NextDouble();

            Console.WriteLine(num);
            
            
            Console.ReadKey();
        }
    }
};