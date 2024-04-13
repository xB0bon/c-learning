namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String again;
            int computer_score = 0;
            int player_score = 0;
            while (true)
            {   
                Console.Clear();
                Random random = new Random();
                Console.WriteLine("Enter: ROCK, PAPER or SCISSORS");
                String player = Console.ReadLine() ?? "";
                String computer = Convert.ToString(random.Next(1, 6));
                
                

                switch (computer)
                {
                    case "1":
                        computer = "ROCK";
                        break;
                    case "2":
                        computer = "PAPER";
                        break;
                    case "3":
                        computer = "SCISSORS";
                        break;
                    case "4":
                        computer = "ROCK";
                        break;
                    case "5":
                        computer = "PAPER";
                        break;
                    case "6":
                        computer = "SCISSORS";
                        break;
                    default:
                        computer = Convert.ToString(random.Next(1, 3));
                        break;
                    
                    
                }
                while (player.ToLower() != "rock" && player.ToLower() != "scissors" && player.ToLower() != "paper")
                {
                    Console.WriteLine("Enter: ROCK, PAPER or SCISSORS");
                    player = Console.ReadLine() ?? "";
                }

                Console.WriteLine("Player: " + player.ToUpper());
                Console.WriteLine("Computer: " + computer.ToUpper());
                if (player.ToLower() == "rock" && computer.ToLower() == "scissors")
                {
                    Console.WriteLine("You Win!");
                    player_score++;
                }
                else if (player.ToLower() == "paper" && computer.ToLower() == "rock")
                {
                    Console.WriteLine("You Win!");
                    player_score++;
                }
                else if (player.ToLower() == "scissors" && computer.ToLower() == "paper")
                {
                    Console.WriteLine("You Win!");
                    player_score++;
                }
                else if (player.ToLower() == "rock" && computer.ToLower() == "paper")
                {
                    Console.WriteLine("You Lose!");
                    computer_score++;
                }
                else if (player.ToLower() == "paper" && computer.ToLower() == "scissors")
                {
                    Console.WriteLine("You Lose!");
                    computer_score++;
                }
                else if (player.ToLower() == "scissors" && computer.ToLower() == "rock")
                {
                    Console.WriteLine("You Lose!");
                    computer_score++;
                }
                else if (player.ToLower() == "paper" && computer.ToLower() == "paper")
                {
                    Console.WriteLine("Tie!");
                }
                else if (player.ToLower() == "rock" && computer.ToLower() == "rock")
                {
                    Console.WriteLine("Tie!");
                }
                else if (player.ToLower() == "scissors" && computer.ToLower() == "scissors")
                {
                    Console.WriteLine("Tie!");
                }

                Console.WriteLine("Score:");
                Console.WriteLine("Player: " + player_score + " Computer: " + computer_score);
                Console.WriteLine();
                Console.Write("Want play again (y/n)?: ");
                again = Console.ReadLine() ?? "n";
                if (again.ToLower() != "y")
                {
                    break;
                }
            }

            Console.ReadKey();

        }
    }
};