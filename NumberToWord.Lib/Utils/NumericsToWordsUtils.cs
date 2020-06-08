using System.Text;

using NumberToWord.Lib.Constants;

namespace NumberToWord.Lib.Utils
{
    public class NumericsToWordsUtils
    {
        private static NumericsToWordsUtils _instance;

        private NumericsToWordsUtils() { }

        internal static NumericsToWordsUtils Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new NumericsToWordsUtils();
                }
                return _instance;
            }
        }


        internal string ConvertHundredth(int numberOfZeros, int hundredthToConvert)
        {
            var sb = new StringBuilder();
            AppendHundredths(ref sb, hundredthToConvert);
            AppendTenths(ref sb, hundredthToConvert);
            AppendExponential(ref sb, numberOfZeros);
            return sb.ToString();
        }

        private void AppendExponential(ref StringBuilder sb, int numberOfZeros)
        {
            if (numberOfZeros > 0)
            {
                sb.Append($" {WordConstants.PowersOf10[numberOfZeros]}");
            }
        }

        private void AppendHundredths(ref StringBuilder sb, int remainder)
        {
            int hundredth = remainder / 100;
            if (hundredth > 0)
            {
                sb.Append($" {WordConstants.UnderTwenty[hundredth]} hundred");
            }
        }

        private void AppendTenths(ref StringBuilder sb, int remainder)
        {
            int tenths = remainder % 100;
            if (tenths != 0)
            {
                if (tenths < 20)
                {
                    sb.Append($" and {WordConstants.UnderTwenty[tenths]}");
                }
                else
                {
                    var units = tenths % 10;
                    sb.Append($" and {WordConstants.AboveTwenty[tenths - units]} {WordConstants.UnderTwenty[units]}");
                }
            }
        }
    }
}