using System;
using Xunit;
using System.Collections.Generic;

namespace assignment_02.Tests
{
    public class StringUtilityTest
    {
        public static IEnumerable<object[]> ReverseStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "aBc", "cBa" };
            yield return new object[] { "fTE", "ETf" };
            yield return new object[] { "x32h", "h23x" };
            yield return new object[] { "!%$", "$%!" };
            yield return new object[] { "5t\n5", "5\nt5" };
        }
        [Theory]
        [MemberData(nameof(ReverseStringData))]
        public void ReverseStringTest(string input, string expected)
        {
            string result = input.ReverseString();

            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> CapitalizeStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "aBc", "ABC" };
            yield return new object[] { "fTE", "FTE" };
            yield return new object[] { "x32h", "X32H" };
            yield return new object[] { "!%$", "!%$" };
            yield return new object[] { "æøå", "ÆØÅ" };
            yield return new object[] { "5t\n5", "5T\n5" };
        }
        [Theory]
        [MemberData(nameof(CapitalizeStringData))]
        public void CapitalizeStringTest(string input, string expected)
        {
            string result = input.CapitalizeString();

            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> LowercaseStringData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "aBc", "abc" };
            yield return new object[] { "fTE", "fte" };
            yield return new object[] { "X32H", "x32h" };
            yield return new object[] { "!%$", "!%$" };
            yield return new object[] { "ÆØÅ", "æøå" };
            yield return new object[] { "5T\n5", "5t\n5" };
        }
        [Theory]
        [MemberData(nameof(LowercaseStringData))]
        public void LowercaseStringTest(string input, string expected)
        {
            string result = input.LowercaseString();

            Assert.Equal(expected, result);
        }
    }
}
