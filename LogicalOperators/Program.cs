namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // || - or
            // && - and

            Console.WriteLine("Jaka jest temperatura?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 50 || temp <= -50)
            {
                Console.WriteLine("D0 NOT GO OUTSIDE!!!");
            }
            else if (temp >= 15 && temp <= 25)
            {
                Console.WriteLine("temperature is ok");
            }
            
        }
    }
};
