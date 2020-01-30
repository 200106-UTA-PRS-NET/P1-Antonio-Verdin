using System;
using Xunit;

namespace PizzaBox.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test() { }
        public int Id { get; set; }
        [Fact]
        public void FailingTest() { Assert.Equal(1, 22); }


            }
}
