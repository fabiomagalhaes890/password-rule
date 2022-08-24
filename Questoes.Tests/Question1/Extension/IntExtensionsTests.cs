using FluentAssertions;
using Question1.Help.Extensions;

namespace Questions.Test.Question1.Extension
{
    [TestClass]
    public class IntExtensionsTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(184758)]
        [DataRow(856921)]
        [DataRow(9999999)]
        public void Create_WithOutsideTheRangeReturnsFalse(int password)
        {
            password.IsInsideTheRange().Should().BeFalse();
        }

        [TestMethod]
        [DataRow(188759)]
        [DataRow(236775)]
        public void Create_WithInsideTheRangeAndDecreasingReturnsFalse(int password)
        {
            password.IsInsideTheRange().Should().BeTrue();
            password.IsDecreasingRuleValid().Should().BeFalse();
        }

        [TestMethod]
        [DataRow(347779)]
        [DataRow(345789)]
        public void Create_WithInsideTheRangeAndDecreasingRepeatedInvalidReturnsFalse(int password)
        {
            password.IsInsideTheRange().Should().BeTrue();
            password.IsDecreasingRuleValid().Should().BeTrue();
            password.IsNumberOfCharacterValid().Should().BeFalse();            
        }

        [TestMethod]
        [DataRow(222222)]
        [DataRow(334478)]
        [DataRow(444557)]
        public void Create_WithCorrectInformationsReturnsTrue(int password)
        {
            password.IsInsideTheRange().Should().BeTrue();
            password.IsDecreasingRuleValid().Should().BeTrue();
            password.IsNumberOfCharacterValid().Should().BeTrue();
        }
    }
}
