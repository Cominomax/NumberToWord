using Xunit;

using NumberToWord.Lib.Extensions;
using System.Numerics;

namespace NumberToWord.Lib.Tests.Extentions
{
    public class BigIntExtensionsTests
    {
        [Fact]
        public void TestWith51()
        {
            var testValue = new BigInteger(51);

            string wording = testValue.ToWords();

            Assert.Equal("fifty one", wording);
        }

        [Fact]
        public void TestWith214()
        {
            var testValue = new BigInteger(214);

            string wording = testValue.ToWords();

            Assert.Equal("two hundred and fourteen", wording);
        }

        [Fact]
        public void TestWith5_911()
        {
            var testValue = new BigInteger(5_911);

            string wording = testValue.ToWords();

            Assert.Equal("five thousand nine hundred and eleven", wording);
        }

        [Fact]
        public void TestWith100_191()
        {
            var testValue = new BigInteger(100_191);

            string wording = testValue.ToWords();

            Assert.Equal("one hundred thousand one hundred and ninety one", wording);
        }

        [Fact]
        public void TestWith119_692_151_188_754_191()
        {
            var testValue = new BigInteger(119_692_151_188_754_191);

            string wording = testValue.ToWords();

            Assert.Equal("one hundred and nineteen quadrillion six hundred and ninety two trillion one hundred and fifty one billion one hundred and eighty eight million seven hundred and fifty four thousand one hundred and ninety one", wording);
        }
    }
}
