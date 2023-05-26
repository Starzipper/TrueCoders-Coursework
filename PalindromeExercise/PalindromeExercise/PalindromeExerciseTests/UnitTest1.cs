using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("RaceCar", true)]
        [InlineData("Race Car", true)]
        [InlineData("Taco Cat", true)]
        [InlineData("no", false)]
        [InlineData("yes", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("  ", false)]
        public void Test1(string word, bool expected)
        {
            WordSmith wordSmith = new WordSmith();
            bool actual = wordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
