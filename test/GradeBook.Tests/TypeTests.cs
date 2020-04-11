using System;
using Xunit;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelete(string logMessage);
    public delegate double AddNumbersDelegate(List<double> numbers);

    public class TypeTests
    {

        int count = 0;

        [Fact]
        public void WriteLogDelegatePointToMethod() {
            WriteLogDelete log;
            log = ReturnLogMessage;
            log += ReturnLogMessage;
            log += GiveLogMessage;

            var result = log("Hello Delegate!");
            Console.WriteLine($"Delegate {result}");

            Assert.Equal(3, count);
        }

        [Fact]
        public void AddNumbersDelegateTest() {
            AddNumbersDelegate addNumbers;
            addNumbers = AddNumbers;
            var numbersList = new List<double>();
            numbersList.Add(10.23);
            numbersList.Add(11);
            numbersList.Add(10);

            var result = addNumbers(numbersList);

            Assert.Equal(31.23, result);
        }

        string ReturnLogMessage(string logMessage) {
            count++;
            return logMessage;
        }

        string GiveLogMessage(string logMessage) {
            count++;
            return logMessage.ToLower();
        }

        double AddNumbers(List<double> numbers) {
            var result = 0.0;
            foreach(var number in numbers) {
                result += number;
            }
            return result;
        }
        
        [Fact]
        public void ValueTypesPassByValue() 
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref Int32 x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 4;
        }

        [Fact]
        public void PassByReferencetoParameter() 
        {
            var book1 = GetBook("Book1");
            SetNameByReference(out book1, "New Book");
            book1.Name = "Third Book";

            Assert.Equal("Third Book", book1.Name);
        }

        private void SetNameByReference(out InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

                
        [Fact]
        public void PassByValuetoParameter() 
        {
            var book1 = GetBook("Book1");
            GetSetName(book1, "New Book");

            Assert.Equal("Book1", book1.Name);
        }

        private void GetSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }
        
        [Fact]
        public void CanSetNewNameFromReference() {
            var book1 = GetBook("Book1");
            SetName(book1, "New Book");

            Assert.Equal("New Book", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
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
        public void TwoVarsReferenceSameObject() 
        {
            var book1 = new InMemoryBook("Book1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void StringBehaveLikeValueTypes() 
        {
            var name = "chandio";
            var upper = ChangeToUpperCase(name);
            var name2 = "JOHN";
            ChangeToLowerCase(name2);

            Assert.Equal("chandio", name);
            Assert.Equal("CHANDIO", upper);
            
            Assert.Equal("JOHN", name2);
        }

        private string ChangeToUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        private void ChangeToLowerCase(string parameter)
        {
            parameter = "QUIOR";
            // return parameter;
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
