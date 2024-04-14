namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = CheckOut(1.33, 21.5, 100.99);

            Console.WriteLine("Total: " + total);
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

        

        
    }
};