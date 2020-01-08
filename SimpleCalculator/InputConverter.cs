using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string inputAsString)
        {
            double convertedNumber;

            if (!double.TryParse(inputAsString, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;
        }
    }
}
