namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            try
            {
                Console.WriteLine("Enter number 1:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number 2:");
                y = Convert.ToDouble(Console.ReadLine());
                double result = x / y;
                Console.WriteLine($"{x} / {y} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter ONLY numbers!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }

            
        }

        
        

        
    }
};