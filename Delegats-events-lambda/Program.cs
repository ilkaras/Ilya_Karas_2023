using System;

namespace Delegates_events_lambda
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Choose the action: '+','-','*' or '/'");
            string action = Console.ReadLine();
            Console.WriteLine("Enter first number");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float secondNum = float.Parse(Console.ReadLine());
            calculator.Notify += DisplayMessage;
            float result;

            switch (action)
            {
                case "+":
                    result = calculator.Calculate(firstNum, secondNum, calculator.Plus);
                    break;

                case "-":
                    result = calculator.Calculate(firstNum, secondNum, calculator.Minus);
                    break;

                case "*":
                    result = calculator.Calculate(firstNum, secondNum, calculator.Multiply);
                    break;

                case "/":
                    result = calculator.Calculate(firstNum, secondNum, calculator.Divide);
                    break;

                default:
                    Console.WriteLine("Invalid action.");
                    return;
            }

            calculator.OnNotify($"Result: {result}");
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}