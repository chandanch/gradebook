using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        
        [Fact]
        public void ValueTypesPassByValue() {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 4;
        }

        [Fact]
        public void PassByReferencetoParameter() {
            var book1 = GetBook("Book1");
            SetNameByReference(out book1, "New Book");
            book1.Name = "Third Book";

            Assert.Equal("Third Book", book1.Name);
        }

        private void SetNameByReference(out Book book, string name)
        {
            book = new Book(name);
        }

                
        [Fact]
        public void PassByValuetoParameter() {
            var book1 = GetBook("Book1");
            GetSetName(book1, "New Book");

            Assert.Equal("Book1", book1.Name);
        }

        private void GetSetName(Book book, string name)
        {
            book = new Book(name);
        }
        
        [Fact]
        public void CanSetNewNameFromReference() {
            var book1 = GetBook("Book1");
            SetName(book1, "New Book");

            Assert.Equal("New Book", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnDistinctObjects()
        {
           var book1 = GetBook("Book1");
           var book2 = GetBook("Book2");

        //    Assert.Equal("Book1", book1.Name);
        //    Assert.Equal("Book2", book2.Name);

           Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsReferenceSameObject() {
            var book1 = new Book("Book1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
