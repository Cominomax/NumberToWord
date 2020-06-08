using System.Text;

namespace NumberToWord.Lib.Extensions
{
    public static class StringBuilderExtentions
    {
        public static StringBuilder Preppend(this StringBuilder @this, string toPreppend)
        {
            @this.Insert(0, toPreppend);
            return @this;
        }

        internal static string ToNumberToWordResultString(this StringBuilder @this)
        {
            var stringResult = @this.ToString();
            if (stringResult.StartsWith(" and "))
            {
                stringResult = stringResult.Remove(0, 5);
            }

            return stringResult.Trim();
        }
    }
}