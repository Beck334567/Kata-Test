using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace LeetCodeTest
{
    [TestFixture()]
    public class LeetCodeUnitTest
    {
        //Leetcode no.3
        [Test()]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void LongestSubstringWithoutRepeatingCharacters(string input, int output)
        {
            //Arrange
            var ex = new LongestSubstringWithoutRepeatingCharacters();

            //Act
            var result = ex.LengthOfLongestSubstring(input);

            //Assert
            NUnit.Framework.Assert.AreEqual(result, output);
        }

        //Leetcode no.3
        [Test()]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void LongestSubstringWithoutRepeatingCharacters(string input, int output)
        {
            //Arrange
            var ex = new LongestSubstringWithoutRepeatingCharacters();

            //Act
            var result = ex.LengthOfLongestSubstring(input);

            //Assert
            NUnit.Framework.Assert.AreEqual(result, output);
        }
    }
}
