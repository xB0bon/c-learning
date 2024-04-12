namespace CypotenuseCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double wynik = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenuse is " + wynik);
        }
    }
};