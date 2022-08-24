using FluentAssertions;
using Question1.Application;

namespace Questions.Test.Question1.Application
{
    [TestClass]
    public class ApplicationPasswordServiceTests
    {
        [TestMethod]
        public void Create_WithOutsideTheRangeReturnsZero()
        {
            var actual = ApplicationPasswordService.CalculatePossibilitiesBetween(1, 100);

            actual.Should().Be(0);
        }

        [TestMethod]
        public void Create_WithDecreasingReturnsZero()
        {
            var actual = ApplicationPasswordService.CalculatePossibilitiesBetween(184759, 184790);

            actual.Should().Be(0);
        }

        [TestMethod]
        public void Create_WithRepeatedInvalidReturnsZero()
        {
            var actual = ApplicationPasswordService.CalculatePossibilitiesBetween(347779, 347785);

            actual.Should().Be(0);
        }

        [TestMethod]
        public void Create_WithCorrectInformationsReturns1380()
        {
            var actual = ApplicationPasswordService.CalculatePossibilitiesBetween(184759, 856920);

            actual.Should().Be(1380);
        }
    }
}
