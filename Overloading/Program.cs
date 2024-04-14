namespace Retrun
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.Write("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());
            double result = Multiply(1, 2, 3);
            Console.WriteLine($"{x} * {y} = {result}");
        }

        static double Multiply(double x, double y) // typ danych który zwracamy
        {
            return x * y;
        }
        static double Multiply(double x, double y, double z) // typ danych który zwracamy
        {
            return x * y;
        }

        
    }
};