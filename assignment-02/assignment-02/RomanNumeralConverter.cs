using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_01
{
    public class RomanNumeralConverter
    {
        public string NumeralToRoman(int num)
        {
            Dictionary<int, string> NumberRomanDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };
            var roman = new StringBuilder();
            foreach (var item in NumberRomanDictionary)
            {
                while (num >= item.Key)
                {
                    roman.Append(item.Value);
                    num -= item.Key;
                }
            }
            return roman.ToString();
        }
    }
}
