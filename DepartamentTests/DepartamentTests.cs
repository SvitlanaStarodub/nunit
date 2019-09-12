using System;
using NUnit.Framework;
using Hometask;
using NUnit.Framework.Constraints;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(18)]
        [TestCase(52)]
        [TestCase(60)]
        public void Validate_Age_Positive(int expected)
        {
            //arrange
            var employee = new Programmer("first", "last", 25);
            //act
            employee.Age = expected;
            //assert
            Assert.AreEqual(expected, employee.Age);
        }

        [Test]
        [TestCase(17)]
        [TestCase(61)]
        public void Validate_AgeIsLessThanRequired_ThrowsArgumentException(int expected)
        {
            //arrange
            var employee = new Programmer("first", "last", 25);
            string expectedExceptionMessage = "Value does not fall within the expected range.";
            //act, assert
            ArgumentException exception = Assert.Throws<ArgumentException>(() => { employee.Age = expected; });
            //assert
            Assert.AreEqual(expectedExceptionMessage, exception.Message);

        }

        [Test]
        public void ShouldThrowExceptionIfEmployeeIsNull()
        {
            //arrange
            var department = new Department();
            //act, assert
            Assert.Throws<NullReferenceException>(() => department.Add(null));

        }

        [Test]
        public void Employee_IsNotNull_ShouldNotTrowException()
        {
            //arrange
            var department = new Department();
            var programmer = new Programmer("first", "last", 25);

            //act
            var testDelegate = new TestDelegate(() => department.Add(programmer));

            //assert
            Assert.DoesNotThrow(testDelegate, "The argument expected to be not null");
        }

        [Test]
        public void VerifyThatAllEmployeesAreAdded()
        {
            // Arrange
            var programmer1 = new Programmer("first", "last", 25);
            var programmer2 = new Programmer("first", "last", 35);

            var department = new Department();
            department.Add(programmer1);
            department.Add(programmer2);

            // Act
            var actual = department.GetAll();

            // Assert 
            Assert.AreEqual(actual, new List<Employee> { programmer1, programmer2 });
        }

        [Test]
        public void VerifyEmployeeSorting()
        {
            // Arrange
            var programmer1 = new Programmer("first", "last", 25);
            var programmer2 = new Programmer("first", "last", 35);

            var department = new Department();
            department.Add(programmer1);
            department.Add(programmer2);

            List<Employee> expectedResult = new List<Employee> { programmer1, programmer2 };

            // Act
            department.Sort();
            var actualResult = department.GetAll();

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "should sort department's programmers");
        }

        [Test]
        public void NumberIsBiggerThanAnother_IsTrue()
        {
            //arrange
            int a = 8;
            int b = 12;
            //act, assert
            Assert.IsTrue(b > a, "2nd number is not bigger than the 1st one");
        }

        [Test]
        public void ListIsNotNull()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Assert.IsNotNull(list, "The list should not be null");
        }

        [Test]
        public void ArraysLength_AreEqual()
        {
            int[] array1 = { 6, 7, 8, 9, 10 };
            string[] array2 = { "a", "b", "c", "d", "e" };
            int length1 = array1.Length;
            int length2 = array2.Length;
            Assert.AreEqual(length1, length2, "Arrays do not have the same length.");
        }

        [Test]
        public void ShouldThrow_IndexOutOfRange()
        {
            int[] array = new int[2];
            Assert.Throws<IndexOutOfRangeException>(() => array[3] = 1);
        }

        [Test]
        public void ShouldThrow_InvalidCastException()
        {
            object obj = "you";
            int num;
            Assert.Throws<InvalidCastException>(() => num = (int)obj);
        }

        [Test]
        public void StringsAreEqual()
        {
            string b = "cbd";
            Assert.AreEqual(b, b.Replace("abc", "cbd"));
        }


    }
}