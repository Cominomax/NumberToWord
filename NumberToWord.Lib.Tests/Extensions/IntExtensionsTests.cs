using Xunit;

using NumberToWord.Lib.Extensions;

namespace NumberToWord.Lib.Tests
{
    public class IntExtensionTests
    {
        [Fact]
        public void TestWith51()
        {
            var testValue = 51;

            string wording = testValue.ToWords();

            Assert.Equal("fifty one", wording);
        }

        [Fact]
        public void TestWith214()
        {
            var testValue = 214;

            string wording = testValue.ToWords();

            Assert.Equal("two hundred and fourteen", wording);
        }

        [Fact]
        public void TestWith5_911()
        {
            var testValue = 5_911;

            string wording = testValue.ToWords();

            Assert.Equal("five thousand nine hundred and eleven", wording);
        }

        [Fact]
        public void TestWith100_191()
        {
            var testValue = 100_191;

            string wording = testValue.ToWords();

            Assert.Equal("one hundred thousand one hundred and ninety one", wording);
        }
    }
}
