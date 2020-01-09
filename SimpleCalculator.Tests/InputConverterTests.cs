using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class InputConverterTests
    {
        private InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "5";

            // Act
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "hello";

            // Act
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            // No Assert - testing for thrown exception
        }
    }
}
