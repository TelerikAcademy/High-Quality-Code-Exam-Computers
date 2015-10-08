namespace Computers.Tests
{
    using Logic;
    using Logic.Cpus;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class CpuRandTests
    {
        [TestMethod]
        public void RandShouldNotProduceNumberLessThanMinValue()
        {
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            var globalMin = int.MaxValue;
            motherboardMock.Setup(
                x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(param => globalMin = Math.Min(globalMin, param));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(1, globalMin);
        }

        [TestMethod]
        public void RandShouldNotProduceNumberGreaterThanMaxValue()
        {
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            var globalMax = int.MinValue;
            motherboardMock.Setup(
                x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(param => globalMax = Math.Max(globalMax, param));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(10, globalMax);
        }

        [TestMethod]
        public void RandShouldAlwaysReturnRandomNumbers()
        {
            var hashSet = new HashSet<int>();
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            motherboardMock.Setup(
                x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(param => hashSet.Add(param));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(10, hashSet.Count);
        }
    }
}
