using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.Strategy;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void StrategySuccess()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            var resultA = context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            var resultB = context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            var resultC = context.ContextInterface();

            Assert.AreEqual(resultA, "實現算法A");
            Assert.AreEqual(resultB, "實現算法B");
            Assert.AreEqual(resultC, "實現算法C");
        }
    }
}
