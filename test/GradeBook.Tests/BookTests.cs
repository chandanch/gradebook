using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange
            var book = new Book("");
           book.AddGrade(34.34);
           book.AddGrade(33.12);
           book.AddGrade(32.12);
            // act
           var result = book.GetStatistics();

            // assert
            Assert.Equal(34.34, result.Highest);
            Assert.Equal(32.12, result.Lowest);
            Assert.Equal(33.19, result.Average, 2);
        }
    }
}
