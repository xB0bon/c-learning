namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine(i);
            //}
            Console.Write("how many columns:");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("symbol: ");
            String symbol = Console.ReadLine() ?? "";
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= colums; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


        }


    }

};