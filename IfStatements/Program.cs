namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1
            Console.WriteLine("Enter Your name: ");
            String name = Console.ReadLine() ?? "";
            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!");
            }
            
            
            //2
            Console.WriteLine("Enter your age!: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("You haven't born yet!");
            }
            else if (age >= 160)
            {
                Console.WriteLine("Really? CONGRATULATION");
            }
            else if (age >= 100)
            {
                Console.WriteLine("You are very Old!");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You are Senior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (age >= 17)
            {
                Console.WriteLine("You are a Teenager! ");
            }
            else
            {
                Console.WriteLine("You are a Child! ");
            }

            
            
        }
    }
};