namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter your name:");
            String name = Console.ReadLine() ?? "";
            Console.Clear();
            while (name == "")
            {
                Console.Write("Enter your name:");
                name = Console.ReadLine() ?? "";
                Console.Clear();
            }

            Console.WriteLine("hello " + name);
        }
    }
};