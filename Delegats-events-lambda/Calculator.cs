using System;

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

        public void OnNotify(string message)
        {
            Notify?.Invoke(message);
        }
    }
}
