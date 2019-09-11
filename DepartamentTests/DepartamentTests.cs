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
        public void EmployeeIsNotNull()
        {
            //arrange

            //act
            if (employee != null)
            {
                //assert
                Assert.IsNotNull(employee, "Employee is not null");
            }



        }
    }
}