namespace RomanNumeralsKata.Core
{
    public class RomanNumeralsConverter
    {
        public string ConvertToRomanNumeral(int number)
        {
            if (number <= 10)
                return GetRomanNumeralUnits(number);

            if (number > 10 && number <= 20)
                return GetRomanNumeralTens(number);

            return string.Empty;
        }

        private string GetRomanNumeralUnits(int number)
        {
            switch (number)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                case 10:
                    return "X";
                default:
                    return string.Empty;
            }
        }

        private string GetRomanNumeralTens(int number)
        {
            string result = string.Empty;
            var tens = number / 10;
            var units = number % 10;

            for (int i = 0; i < tens; i++)
            {
                result += GetRomanNumeralUnits(10);
            }

            result += GetRomanNumeralUnits(units);

            return result;
        }
    }
}