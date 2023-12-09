namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            string answer;
            Console.WriteLine("Hello! Welcome to the calculator");
            Console.WriteLine("Please enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("Please enter a for addition, s for substrsction, m for multiplication, d for division") ;

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine("The result is: " +result);

            Console.WriteLine("Thank you for using basic calculator program");
            Console.ReadKey();
        }
    }
}