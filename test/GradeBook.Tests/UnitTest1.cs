using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var x = 5;
            var y = 5;
            var expected = 10;

            // act
            var actual = x + y;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
