using Xunit;

namespace RefactorFunction.Core.Tests {
    public class ControlDigitTest {
        [Fact]
        public void Initialize() {
            var controlDigit = new ControlDigit();

            Assert.NotNull(controlDigit);
        }

        [Theory]
        [InlineData(123456, 3)]
        [InlineData(0, 0)]
        [InlineData(9876543210, 1)]
        public void Calculate_ReturnsModulo(long number, int expected) {
            var controlDigit = new ControlDigit();

            var result = controlDigit.Calculate(number);

            Assert.Equal(expected, result);
        }
    }
}