namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?: ");
            String name = Console.ReadLine() ?? "";  // ?? "" - domyslna wartosc
            
            Console.WriteLine("Hello " + name + " !");
            
            Console.WriteLine("What's your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are " + age + " years old.");
            
            
            Console.ReadKey();
            
        }
    }
};