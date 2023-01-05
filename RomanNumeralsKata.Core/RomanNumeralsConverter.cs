namespace RomanNumeralsKata.Core
{
    public class RomanNumeralsConverter
    {
        public static string ConvertToRomanNumeral(int number)
        {
            if (number > 0)
                return ConvertToRomanNumeralString(number);

            throw new ArgumentException("Please enter a value greater than 0");
        }

        private static string ConvertToRomanNumeralString(int number)
        {
            string result = string.Empty;

            var noOfThousands = number / 1000;
            var remainderHundreds = number % 1000;
            var noOfHundreds = remainderHundreds / 100;
            var remainderTens = remainderHundreds % 100;
            var noOfTens = remainderTens / 10;
            var noOfUnits = remainderTens % 10;

            result += ConvertThousandsToRomanNumeralString(noOfThousands * 1000);
            result += ConvertHundredsToRomanNumeralString(noOfHundreds * 100);
            result += ConvertTensToRomanNumeralString(noOfTens * 10);
            result += ConvertUnitsToRomanNumeralString(noOfUnits);

            return result;
        }

        private static string ConvertThousandsToRomanNumeralString(int number)
        {
            return number switch
            {
                1000 => "M",
                2000 => "MM",
                _ => string.Empty,
            };
        }

        private static string ConvertHundredsToRomanNumeralString(int number)
        {
            return number switch
            {
                100 => "C",
                200 => "CC",
                300 => "CCC",
                400 => "CD",
                500 => "D",
                600 => "DC",
                700 => "DCC",
                800 => "DCCC",
                900 => "CM",
                _ => string.Empty,
            };
        }

        private static string ConvertTensToRomanNumeralString(int number)
        {
            return number switch
            {
                10 => "X",
                20 => "XX",
                30 => "XXX",
                40 => "XL",
                50 => "L",
                60 => "LX",
                70 => "LXX",
                80 => "LXXX",
                90 => "XC",
                _ => string.Empty,
            };
        }

        private static string ConvertUnitsToRomanNumeralString(int number)
        {
            return number switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => string.Empty,
            };
        }
    }
}