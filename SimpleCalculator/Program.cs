using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            Console.WriteLine("Please enter your first number");
            double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());

            Console.WriteLine("Please enter the operation");
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine($"Your answer is: {result}");
        }

    }
}
