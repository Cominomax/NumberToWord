using System.Text;

using NumberToWord.Lib.Utils;

namespace NumberToWord.Lib.Extensions
{
    public static class IntExtensions
    {
        public static string ToWords(this int value)
        {
            var utils = new NumericsToWordsUtils();
            var result = new StringBuilder();
            var remainder = value;
            int numberOfZeros = 0;

            while (remainder > 0)
            {
                var hundredthStringWithExponential = utils.ConvertHundredth(numberOfZeros, remainder % 1000);
                result.Preppend(hundredthStringWithExponential);

                remainder /= 1000;
                numberOfZeros += 3;
            }

            return result.ToNumberToWordResultString();
        }

        
    }
}