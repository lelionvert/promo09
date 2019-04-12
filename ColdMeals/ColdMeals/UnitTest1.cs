using NUnit.Framework;
using FluentAssertions;
namespace Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            bool flag = true;
            flag.Should().Be(true);
        }
    }
}