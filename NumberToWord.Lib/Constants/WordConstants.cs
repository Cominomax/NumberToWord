using System.Collections.Generic;

namespace NumberToWord.Lib.Constants
{
    internal static class WordConstants
    {
        internal static Dictionary<int, string> PowersOf10 { get; set; }
        internal static Dictionary<int, string> UnderTwenty { get; set; }
        internal static Dictionary<int, string> AboveTwenty { get; set; }

        static WordConstants()
        {
            PowersOf10 = new Dictionary<int, string>();
            PowersOf10.Add(0, string.Empty);
            PowersOf10.Add(3, "thousand");
            PowersOf10.Add(6, "million");
            PowersOf10.Add(9, "billion");
            PowersOf10.Add(12, "trillion");
            PowersOf10.Add(15, "quadrillion");
            PowersOf10.Add(18, "quintillion");
            PowersOf10.Add(21, "sextillion");
            PowersOf10.Add(24, "septillion");
            PowersOf10.Add(27, "octillion");
            PowersOf10.Add(30, "nonillion");
            PowersOf10.Add(33, "decillion");

            UnderTwenty = new Dictionary<int, string>();
            UnderTwenty.Add(1, "one");
            UnderTwenty.Add(2, "two");
            UnderTwenty.Add(3, "three");
            UnderTwenty.Add(4, "four");
            UnderTwenty.Add(5, "five");
            UnderTwenty.Add(6, "six");
            UnderTwenty.Add(7, "seven");
            UnderTwenty.Add(8, "eight");
            UnderTwenty.Add(9, "nine");
            UnderTwenty.Add(10, "ten");
            UnderTwenty.Add(11, "eleven");
            UnderTwenty.Add(12, "twelve");
            UnderTwenty.Add(13, "thirteen");
            UnderTwenty.Add(14, "fourteen");
            UnderTwenty.Add(15, "fifteen");
            UnderTwenty.Add(16, "sixteen");
            UnderTwenty.Add(17, "seventeen");
            UnderTwenty.Add(18, "eighteen");
            UnderTwenty.Add(19, "nineteen");

            AboveTwenty = new Dictionary<int, string>();
            AboveTwenty.Add(20, "twenty");
            AboveTwenty.Add(30, "thirty");
            AboveTwenty.Add(40, "fourty");
            AboveTwenty.Add(50, "fifty");
            AboveTwenty.Add(60, "sixty");
            AboveTwenty.Add(70, "seventy");
            AboveTwenty.Add(80, "eighty");
            AboveTwenty.Add(90, "ninety");
        }
    }
}