using System;
using NUnit.Framework;
using Hometask;
using NUnit.Framework.Constraints;

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
        public void Validate_Age_Negative(int expected)
        {
            //arrange
            var employee = new Programmer("first", "last", 25);
            //act, assert
            //Assert.Throws<ArgumentException>(() => { employee.Age = expected; }).message;

        }

        [Test]
        public void ShouldThrowExceptionIfEmployeeIsNull()
        {
            //arrange
            var department = new Department();
            //act, assert
            Assert.Throws<NullReferenceException>(() => department.Add(null));

        }
    }
}