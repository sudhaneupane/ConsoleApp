namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result;
            string answer;
            Console.WriteLine("Hello! Welcome to the calculator");
            Console.WriteLine("Please enter your first number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("Please enter a for addition, s for substrsction, m for multiplication, any other key for division") ;

            answer = Console.ReadLine().ToLower();

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
                result =num2==0? float.NaN: num1 / num2;
            }
            if (float.IsNaN(result))
            {
                Console.WriteLine("Cannot perform division by 0!");
            }
            else
            {
                Console.WriteLine("The result is: " + result);
            }

            Console.ReadKey();
        }
    }
}
