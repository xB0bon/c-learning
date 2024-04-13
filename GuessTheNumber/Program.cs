namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Random random = new Random();
                bool guess = false;
                String play_again;
                int num = random.Next(1, 100);
                int x;
                int guesses = 0;
                Console.WriteLine("Guess the number from 1 to 100");
                while (!guess)
                {
                    Console.Write("Enter Number:");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > num)
                    {
                        guesses++;
                        Console.WriteLine("it's too big number! attempts: "+ guesses);
                    }
                    else if (x < num)
                    {
                        guesses++;
                        Console.WriteLine("It's too small number! attempts: "+ guesses);
                    }
                    else if (x == num)
                    {
                        guess = true;
                    }
                }

                Console.WriteLine("You win in " + guesses + " attempts");
                 
                
                Console.WriteLine("Want play again?: (y/n)");
                play_again = Console.ReadLine() ?? "";

                if (play_again.ToLower() != "y")
                {
                    break;
                }
                Console.Clear();
            }

            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
};