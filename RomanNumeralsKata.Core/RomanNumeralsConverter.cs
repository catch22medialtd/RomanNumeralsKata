namespace RomanNumeralsKata.Core
{
    public class RomanNumeralsConverter
    {
        public string ConvertToRomanNumeral(int number)
        {
            if(number == 1)
                return "I";

            if (number == 2)
                return "II";

            if (number == 3)
                return "III";

            return string.Empty;
        }
    }
}