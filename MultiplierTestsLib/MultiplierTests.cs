using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class MultiplierTests
    {
        [TestMethod]
        public void Simple()
        {
            Multiplier sut = new Multiplier();
            var actual = sut.Simple(20, 20);
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void UsingFor()
        {
            Multiplier sut = new Multiplier();
            var actual = sut.UsingFor(20, 20);
            Assert.AreEqual(400, actual);
        }
    }
}
