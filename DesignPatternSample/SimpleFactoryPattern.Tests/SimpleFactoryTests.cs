using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactoryPattern.SimpleFactory;

namespace SimpleFactoryPattern.Tests
{
    [TestClass]
    public class SimpleFactoryTests
    {
        [TestMethod]
        public void SimpleFactory_Success_Test()
        {
            Operation oper;
            oper = OperationFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            var addResult = oper.GetResult();
            Assert.AreEqual(addResult, 1 + 2);

            oper = OperationFactory.CreateOperate("-");
            oper.NumberA = 1;
            oper.NumberB = 2;
            var subResult = oper.GetResult();
            Assert.AreEqual(subResult, 1 - 2);

            oper = OperationFactory.CreateOperate("*");
            oper.NumberA = 1;
            oper.NumberB = 2;
            var mulResult = oper.GetResult();
            Assert.AreEqual(mulResult, 1 * 2);

            oper = OperationFactory.CreateOperate("/");
            oper.NumberA = 1;
            oper.NumberB = 2;
            var divResult = oper.GetResult();
            Assert.AreEqual(divResult, 1.00 / 2.00);
        }

        [TestMethod]
        public void SimpleFactory_OprationFailException_Test()
        {
            try
            {
                Operation oper;
                oper = OperationFactory.CreateOperate("!!");
                oper.NumberA = 1;
                oper.NumberB = 2;
                var result = oper.GetResult();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "不支援此運算符號");
            }
        }

        [TestMethod]
        public void SimpleFactory_DivEqualZeroException_Test()
        {
            try
            {
                Operation oper;
                oper = OperationFactory.CreateOperate("/");
                oper.NumberA = 1;
                oper.NumberB = 0;
                var result = oper.GetResult();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "除數不能為0");
            }
        }
    }
}
