using NUnit.Framework;
using StringManipulation;

namespace UnitTests
{
    public class SentenceReverserTests
    {
        [Test]
        [TestCase("One Two Three Four Five Six", "Six Five Four Three Two One")]
        [TestCase(" One Two Three Four Five Six", "Six Five Four Three Two One ")]
        [TestCase(" One  Two Three Four Five  Six", "Six  Five Four Three Two  One ")]
        [TestCase("  ", "  ")]
        [TestCase("test", "test")]
        [TestCase(" test test2 ", " test2 test ")]
        public void ReverseStringTest(string input, string expected)
        {
            var SUT = new SentenceReverser();

            var result = SUT.ReverseSentence(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase( "One Two Three Four Five Six", "Six Five Four Three Two One")]
        [TestCase(" One Two Three Four Five Six", "Six Five Four Three Two One ")]
        [TestCase("  ", "  ")]
        [TestCase("test", "test")]
        [TestCase(" test test2 ", " test2 test ")]
        public void ReverseCharArrayTest(string input, string expected)
        {
            var charInput = input.ToCharArray();
            var charExpected = expected.ToCharArray();

            var SUT = new SentenceReverser();

            var result = SUT.ReverseSentence(charInput);

            Assert.AreEqual(charExpected, result);
        }

        [Test]
        [TestCase("One,Two,Three,Four,Five,Six", "Six,Five,Four,Three,Two,One")]
        [TestCase(",One,Two,Three,Four,Five,Six", "Six,Five,Four,Three,Two,One,")]
        [TestCase(",,", ",,")]
        [TestCase("test", "test")]
        [TestCase(",test,test2,", ",test2,test,")]
        public void ReverseStringWithSpecifiedSeparatorTest(string input, string expected)
        {
            var SUT = new SentenceReverser();

            var result = SUT.ReverseSentence(input, ',');

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("One,Two,Three,Four,Five,Six", "Six,Five,Four,Three,Two,One")]
        [TestCase(",One,Two,Three,Four,Five,Six", "Six,Five,Four,Three,Two,One,")]
        [TestCase(",,", ",,")]
        [TestCase("test", "test")]
        [TestCase(",test,test2,", ",test2,test,")]
        public void ReverseCharArrayWithSpecifiedSeparatorTest(string input, string expected)
        {
            var charInput = input.ToCharArray();
            var charExpected = expected.ToCharArray();

            var SUT = new SentenceReverser();

            var result = SUT.ReverseSentence(charInput, ',');

            Assert.AreEqual(charExpected, result);
        }
    }
}