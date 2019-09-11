using NUnit.Framework;
using Hometask;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [TestCase(18)]
        [TestCase(52)]
        [TestCase(60)]
        public void Validate_Age_Positive(int actual)
        {
            //act
            if (actual >= 18 || actual <= 60)
            //assert
            Assert.IsTrue(true, "Age is valid");
        }


        //public void EmployeeIsNotNull()
        //{
        //    //arrange

        //    //act
        //    if (employee != null)
        //    {
        //        //assert
        //        Assert.IsNotNull(employee, "Employee is not null");
        //    }

        //}
    }
}