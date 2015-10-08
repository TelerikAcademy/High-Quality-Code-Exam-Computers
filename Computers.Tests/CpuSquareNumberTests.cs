namespace Computers.Tests
{
    using Logic;
    using Logic.Cpus;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CpuSquareNumberTests
    {
        [TestMethod]
        public void SqureNumberShouldOutputCorrectValues()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(123);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param.Contains("15129"))));
        }

        [TestMethod]
        public void SquareNumberShouldDrawErrorMessageWhenValueIsLessThanZero()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(-1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooLowMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu32ShouldDrawErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu32.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooHighMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu64ShouldDrawErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu64(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu64.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooHighMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu128ShouldDrawErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu128(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu128.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooHighMessage)));
        }
    }
}
