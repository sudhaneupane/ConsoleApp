using System;
namespace CombactFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;
            int healAmount = 5;
            Random random = new Random();

            int playerAttack = 5;
            int enemyAttack = 7;

            while(playerHp>0 && enemyHp > 0)
            {//player turn
                Console.WriteLine("Player Hp= " + playerHp +" Enemy Hp= " + enemyHp) ;
                Console.WriteLine("--Player Turn--");
                Console.WriteLine();
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");
                
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp =enemyHp-playerAttack;
                    Console.WriteLine("Player attacked and dealed " + playerAttack + " damage");
                    Console.WriteLine();

                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("player got " +healAmount +" heal amount");
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(1000);
                //enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("--Enemy turn--");
                    Console.WriteLine();
                    Console.WriteLine("Player Hp= " + playerHp + " Enemy Hp= " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacked and dealed "+enemyAttack+" damage");
                        Console.WriteLine();
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy got "+healAmount + "heal points");
                        Console.WriteLine();
                    }
                }

            }
            if (playerHp > 0)
            {
                Console.WriteLine("Congrulations you have won");
            }
            else
            {
                Console.WriteLine("You lose ");
            }

            Console.ReadKey();

        }
    }
}