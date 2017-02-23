using apps.Controllers;
using System;
using Xunit;

namespace WebAPISample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(false);
        }

        [Fact]
        public void Test2()
        {
            var vc = new ValuesController();
            Assert.Equal(new[] { "value1", "value2" }, vc.Get());
        }
    }
}
