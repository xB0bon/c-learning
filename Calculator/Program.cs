namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double result;
                Console.WriteLine("------------");
                Console.WriteLine("CALCULATOR");
                Console.WriteLine("------------");
                Console.Write("Enter number 1: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------"); 
                Console.WriteLine("\t+ : Addition: "); 
                Console.WriteLine("\t- : Substact: ");
                Console.WriteLine("\t* : Multiply: ");
                Console.WriteLine("\t/ : Divide: ");
                Console.Write("Enter an option:");
                String option = Console.ReadLine() ?? "";
                while (option != "+" && option != "-" && option != "/" && option != "*")
                {
                    Console.Write("Enter an option:");
                    option = Console.ReadLine() ?? "";
                }
                
                switch (option)
                {
                    case "+":
                        result = x + y;
                        Console.WriteLine($"{x} + {y} is {result}");
                        break;
                    case "-":
                        result = x - y;
                        Console.WriteLine($"{x} - {y} is {result}");
                        break;
                    case "*":
                        result = x * y;
                        Console.WriteLine($"{x} * {y} is {result}");
                        break;
                    case "/":
                        result = x / y;
                        Console.WriteLine($"{x} / {y} is {result}");
                        break;
                }
                
                Console.WriteLine("Again (y/n)");
                String again = Console.ReadLine() ?? "";
                if (again.ToLower() != "y" && again.ToLower() != "yes")
                {
                    break;
                }
                Console.Clear();
            }
            
            
        }
    }
};