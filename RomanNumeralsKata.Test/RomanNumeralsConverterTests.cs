using FluentAssertions;
using RomanNumeralsKata.Core;

namespace RomanNumeralsKata.Test
{
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
        [Test]
        public void Given_0_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_Error_Is_Returned()
        {
            var ex = Assert.Throws<ArgumentException>(() => RomanNumeralsConverter.ConvertToRomanNumeral(0));

            Assert.That(ex.Message, Is.EqualTo("Please enter a value greater than 0"));
        }

        [Test]
        public void Given_1_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_I_Is_Returned()
        {
            var expected = "I";
            var actual = RomanNumeralsConverter.ConvertToRomanNumeral(1);

            actual.Should().Be(expected, $"Because we entered a value of 1");
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void Given_Number_Less_Than_Or_Equal_To_10_Is_Entered_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            string actual = RomanNumeralsConverter.ConvertToRomanNumeral(number);

            actual.Should().Be(expected, $"Because we entered a value of {number}");
        }

        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        public void Given_Number_Greater_Than_10_And_Less_Than_Or_Equal_To_20_Is_Entered_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            string actual = RomanNumeralsConverter.ConvertToRomanNumeral(number);

            actual.Should().Be(expected, $"Because we entered a value of {number}");
        }

        [TestCase(21, "XXI")]
        [TestCase(22, "XXII")]
        [TestCase(23, "XXIII")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(26, "XXVI")]
        [TestCase(27, "XXVII")]
        [TestCase(28, "XXVIII")]
        [TestCase(29, "XXIX")]
        [TestCase(30, "XXX")]
        [TestCase(31, "XXXI")]
        [TestCase(32, "XXXII")]
        [TestCase(33, "XXXIII")]
        [TestCase(34, "XXXIV")]
        [TestCase(35, "XXXV")]
        [TestCase(36, "XXXVI")]
        [TestCase(37, "XXXVII")]
        [TestCase(38, "XXXVIII")]
        [TestCase(39, "XXXIX")]
        public void Given_Number_Less_Than_Or_Equal_To_39_Is_Entered_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            string actual = RomanNumeralsConverter.ConvertToRomanNumeral(number);

            actual.Should().Be(expected, $"Because we entered a value of {number}");
        }

        [TestCase(40, "XL")]
        [TestCase(41, "XLI")]
        [TestCase(42, "XLII")]
        [TestCase(43, "XLIII")]
        [TestCase(44, "XLIV")]
        [TestCase(45, "XLV")]
        [TestCase(46, "XLVI")]
        [TestCase(47, "XLVII")]
        [TestCase(48, "XLVIII")]
        [TestCase(49, "XLIX")]
        public void Given_Number_Less_Than_Or_Equal_To_49_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            var actual = RomanNumeralsConverter.ConvertToRomanNumeral(number);

            actual.Should().Be(expected, $"Because we entered a value of {number}");
        }

        [Test]
        public void Given_Number_Between_1_And_2000_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned()
        {
            var dataset = RomanNumeralsHelper.GetRomanNumeralsDataSet();

            foreach (var set in dataset)
            {
                var expected = set.Value;
                var actual = RomanNumeralsConverter.ConvertToRomanNumeral(set.Key);

                actual.Should().Be(expected, $"Because we entered a value of {set.Key}");
            }
        }
    }
}