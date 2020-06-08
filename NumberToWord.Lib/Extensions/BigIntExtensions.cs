using System.Numerics;
using System.Text;

using NumberToWord.Lib.Utils;

namespace NumberToWord.Lib.Extensions
{
    public static class BigIntExtensions
    {
        public static string ToWords(this BigInteger value)
        {
            var utils = new NumericsToWordsUtils();
            var result = new StringBuilder();
            var remainder = value;
            int numberOfZeros = 0;

            while (remainder > 0)
            {
                var hundredthStringWithExponential = utils.ConvertHundredth(numberOfZeros, (int)(remainder % 1000));
                result.Preppend(hundredthStringWithExponential);

                remainder /= 1000;
                numberOfZeros += 3;
            }

            return result.ToNumberToWordResultString();
        }
    }
}