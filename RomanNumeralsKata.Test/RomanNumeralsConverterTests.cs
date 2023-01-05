using RomanNumeralsKata.Core;

namespace RomanNumeralsKata.Test
{
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
        private RomanNumeralsConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new();
        }

        [Test]
        public void Given_1_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_I_Is_Returned()
        {
            // Arrange
            string expected = "I";

            // Act
            string actual = _converter.ConvertToRomanNumeral(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void Given_Number_Less_Than_4_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            // Act
            string actual = _converter.ConvertToRomanNumeral(number);

            //Assert
            Assert.AreEqual(expected, actual);
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
        public void Given_Number_Less_Than_Or_Equal_To_10_Is_Enterted_When_ConvertToRomanNumeral_Is_Invoked_Then_Correct_Value_Is_Returned(int number, string expected)
        {
            // Act
            string actual = _converter.ConvertToRomanNumeral(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}