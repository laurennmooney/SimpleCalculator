using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorEngineTests
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("add", number1, number2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            // Arrange
            int number1 = 1;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("+", number1, number2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            // Arrange
            int number1 = 3;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("subtract", number1, number2);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            // Arrange
            int number1 = 3;
            int number2 = 2;

            // Act
            double result = _calculatorEngine.Calculate("-", number1, number2);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
