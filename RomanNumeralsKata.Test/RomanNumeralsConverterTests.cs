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
    }
}