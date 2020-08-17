using System;
using Xunit;
using personLib;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person p = new Person();
            p.Name = "Big Bob";
            p.YearofBirth = 1970;

            Assert.Equal(50, p.calcAge());

        }

        [Theory]
        [InlineData(40, 1980)]
        [InlineData(39, 1981)]
        [InlineData(38, 1982)]

        public void GetAge_Test(int expected, int yob){
            Person p1 = new Person();
            p1.Name = "Big Bob";
            p1.YearofBirth = yob;
            Assert.Equal(expected, p1.calcAge());
        }

        [Fact]
        public void GetAge_ExceptionTest()
        {
           Person p1 = new Person();
            p1.Name = "Big Bob";
            p1.YearofBirth = 1899;
            
            Assert.Throws<Exception>(() => p1.calcAge());
        }


    }
}
