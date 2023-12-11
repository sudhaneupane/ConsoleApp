using System;
namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerScore=0;
            int enemyScore=0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled: " +playerRandomNum);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000); 

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled: " +enemyRandomNum);
                if (playerRandomNum > enemyRandomNum)
                {
                    playerScore++;
                    Console.WriteLine();
                    Console.WriteLine("You win this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyScore++;
                    Console.WriteLine();
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The current score is - Player: " +playerScore + " AI enemy: " +enemyScore);
                Console.WriteLine();
            }
            if (playerScore > enemyScore)
            {
                Console.WriteLine("You win!");
            }
            else if (playerScore < enemyScore)
            {
                Console.WriteLine("Enemy AI wins!");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.ReadKey();
        }
    }
}