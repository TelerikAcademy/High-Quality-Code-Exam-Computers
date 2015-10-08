namespace Computers.Tests
{
    using Computers.Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopBatteryChargeTest
    {
        [TestMethod]
        public void ChargeShouldAddToPercentageWhenGivenPositiveNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(10);
            Assert.AreEqual(60, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotAddToPercentageWhenGivenPositiveNumberAndCurrentPercentageIs100()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 100;
            battery.Charge(10);
            Assert.AreEqual(100, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldSubstractFromPercentageWhenGivenNegativeNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(-10);
            Assert.AreEqual(40, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotSubstractFromPercentageWhenGivenNegativeNumberAndCurrentPercentageIsZero()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 0;
            battery.Charge(-10);
            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotSubstractFromPercentageWhenGivenZero()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(0);
            Assert.AreEqual(50, battery.Percentage);
        }
    }
}
