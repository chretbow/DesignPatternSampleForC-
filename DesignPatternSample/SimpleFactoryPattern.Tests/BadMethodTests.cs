
namespace SimpleFactoryPattern.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SimpleFactoryPattern;

    [TestClass]
    public class BadMethodTests
    {
        [TestMethod]
        public void Computer_Success_Test()
        {
            var badMethod = new BadMethod();

            var addResult = badMethod.Computer(123, 456, "+");

            Assert.AreEqual(addResult, 123 + 456);

            var subResult = badMethod.Computer(123, 456, "-");

            Assert.AreEqual(subResult, 123 - 456);

            var mulResult = badMethod.Computer(123, 456, "*");

            Assert.AreEqual(mulResult, 123 * 456);

            var divResult = badMethod.Computer(123, 456, "/");

            Assert.AreEqual(divResult, (123.00 / 456.00));
        }

        [TestMethod]
        public void Computer_OprationFailException_Test()
        {
            try
            {
                var badMethod = new BadMethod();

                var exResult = badMethod.Computer(123, 456, "!!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "不支援此運算符號");
            }
        }

        [TestMethod]
        public void Computer_DivEqualZeroException_Test()
        {
            try
            {
                var badMethod = new BadMethod();

                var divResult = badMethod.Computer(123, 0, "/");

                Assert.IsNotNull(divResult);

            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "除數不能為0");
            }
        }
    }
}
