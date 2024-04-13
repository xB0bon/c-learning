namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            String name = Console.ReadLine() ?? "";
            while (name == "")
            {
                Console.Write("Name: ");
                name = Console.ReadLine() ?? "";
            }
            Console.Write("How many times  you want to sing birthday song?");
            int times = Convert.ToInt32(Console.ReadLine());
            HappyBirthday(times, name);

        }

        static void HappyBirthday(int times, String name)
        
        {
            for (int i = 1; i < times; i++)
            {
                Console.WriteLine("Happy Birthday to you!");
                Console.WriteLine("Happy Birthday to you!");
                Console.WriteLine($"Happy Birthday to dear {name}!");
                Console.WriteLine("Happy Birthday to you!");
            }
            
        }
    }
};