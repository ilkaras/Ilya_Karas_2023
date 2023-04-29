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
            float result = calculator.Actions(action, firstNum, secondNum);

            calculator.OnNotify($"Result: {result}");
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}