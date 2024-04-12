namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age!: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 100)
            {
                Console.WriteLine("You are too old!");
            }
            
            else if (age  >= 18)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (age <= 0)
            {
                Console.WriteLine("You haven't born yet! ");
            }
            else
            {
                Console.WriteLine("You are a Baby!");
            }
        }
    }
};