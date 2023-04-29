namespace Delegates_events_lambda
{
    public class Calculator
    {
        public delegate float CalculateFunc(float a, float b);
        public delegate void NotifyHandler(string message);
        public event NotifyHandler? Notify;

        public float Plus(float a, float b) => a + b;
        public float Minus(float a, float b) => a - b;
        public float Multiply(float a, float b) => a * b;
        public float Divide(float a, float b) => a / b;

        public float Calculate(float a, float b, CalculateFunc operation)
        {
            return operation(a, b);
        }

        public float Actions(string action, float firstNum, float secondNum)
        {
            float result = 0;
            switch (action)
            {
                case "+":
                    result = Calculate(firstNum, secondNum, Plus);
                    break;

                case "-":
                    result = Calculate(firstNum, secondNum, Minus);
                    break;

                case "*":
                    result = Calculate(firstNum, secondNum, Multiply);
                    break;

                case "/":
                    result = Calculate(firstNum, secondNum, Divide);
                    break;
            }

            return result;
        }

        public void OnNotify(string message)
        {
            Notify?.Invoke(message);
        }
    }
}
