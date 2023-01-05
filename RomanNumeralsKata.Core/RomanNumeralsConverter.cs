namespace RomanNumeralsKata.Core
{
    public class RomanNumeralsConverter
    {
        public string ConvertToRomanNumeral(int number)
        {
            if (number <= 10)
                return ConvertRomanNumeralUnitsToString(number);

            if (number <= 49)
                return ConvertRomanNumeralTensToString(number);

            return string.Empty;
        }

        private string ConvertRomanNumeralUnitsToString(int number)
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

        private string ConvertRomanNumeralTensToString(int number)
        {
            string result = string.Empty;
            var tens = (number / 10) * 10;

            result += DoConvertRomanNumeralTensAsString(tens);

            var units = number - tens;

            result += ConvertRomanNumeralUnitsToString(units);

            return result;
        }

        private string DoConvertRomanNumeralTensAsString(int number)
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
                100 => "C",
                _ => string.Empty,
            };
        }
    }
}