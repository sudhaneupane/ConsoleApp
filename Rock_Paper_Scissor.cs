 namespace Rock_Paper_Scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock, Paper or Scissors!");

            while(playerScore!=3 && enemyScore != 3)
            {
                Console.WriteLine("Player Score: "+playerScore +" Enemy Score: " +enemyScore);
                Console.WriteLine("Please enter r for Rock, p for Paper and anything else for Scissors!");
                string playerChoice = Console.ReadLine();
                int enemyChoice = random.Next(0, 3);
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses Rock!");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("tie");
                            break;
                        case "p":
                            Console.WriteLine("You Win");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;

                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses Paper!");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("tie");
                            break;
                        default:
                            Console.WriteLine("You Win");
                            playerScore++;
                            break;
                    }

                }
                else 
                        { Console.WriteLine("Enemy chooses Scissors!"); }
                switch (playerChoice)
                {
                    case "r":
                        Console.WriteLine("You Win");
                        playerScore++;
                        break;
                    case "p":
                        Console.WriteLine("Enemy Wins");
                        enemyScore++;
                        break;
                    default:
                        Console.WriteLine("tie");
                        break;
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You Win!!!!!");
            }
            else
            {
                Console.WriteLine("You lose");
            }
            Console.ReadKey();
        }
    }
}
