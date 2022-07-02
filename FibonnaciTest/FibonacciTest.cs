using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd;

namespace FibonnaciTest
{
    [TestClass]
    public class FibonacciTest
    {
        private Fibonacci _fibonacci { get; set; }

        public FibonacciTest()
        {
            _fibonacci = new Fibonacci();
        }
        
        [TestInitialize]

        public void Init()
        {
            _fibonacci = new Fibonacci();
        }

        [TestMethod()]
        public void WhenPositionIsOneReturnZero()
        {
            int value = _fibonacci.GetValue(0);
            Assert.AreEqual(0, value);
        }

        [TestMethod]
        public void WhenPositionIsFourReturnTwo()
        {
            int value = _fibonacci.GetValue(4);
            Assert.AreEqual(2, value);
        }

        [TestMethod]
        public void WhenPositionIsElevenReturnFiftyFive()
        {
            int value = _fibonacci.GetValue(11);
            Assert.AreEqual(55, value);
        }

        [TestMethod]
        public void When()
        {
            int value = _fibonacci.GetValue(11);
            Assert.AreEqual(55, value);
        }
    }
}