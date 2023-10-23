using System;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hey", false)]
        [InlineData("civic", true)]
        [InlineData("noon", true)]
        [InlineData("howdy", false)]
        [InlineData("hannah", true)]
        [InlineData("brother", false)]
        public void Test1(string name, bool expected)
        {
            //arrange
            var pal = new WordSmith();

            //act
            var actual = pal.IsAPalendrome(name);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
