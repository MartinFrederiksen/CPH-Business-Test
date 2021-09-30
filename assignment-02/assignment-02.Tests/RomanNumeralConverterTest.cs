using Xunit;

namespace assignment_01.Tests
{
    public class RomanNumeralConverterTest
    {
        [Fact]
        public void Test1()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Test2()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(5);

            Assert.Equal("V", result);
        }

        [Fact]
        public void Test3()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void Test4()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(50);

            Assert.Equal("L", result);
        }

        [Fact]
        public void Test5()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(100);

            Assert.Equal("C", result);
        }

        [Fact]
        public void Test6()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(500);

            Assert.Equal("D", result);
        }

        [Fact]
        public void Test7()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            string result = NumtoRoman.NumeralToRoman(1000);

            Assert.Equal("M", result);
        }

        [Fact]
        public void Test8()
        {
            RomanNumeralConverter NumtoRoman = new RomanNumeralConverter();
            Assert.Equal("MMMMMMMMMMDCCLIV", NumtoRoman.NumeralToRoman(10754));
        }
    }
}
