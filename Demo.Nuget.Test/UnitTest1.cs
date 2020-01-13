using NUnit.Framework;

namespace Demo.Nuget.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var o = new Class1();
            Assert.AreEqual(1, o.Method1());
        }
    }
}