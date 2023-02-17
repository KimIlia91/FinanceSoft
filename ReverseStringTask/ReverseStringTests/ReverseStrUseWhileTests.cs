namespace ReverseStringTests
{
    public class ReverseStrUseWhileTests
    {
        [Fact]
        public void ReverseStrUseWhile_GivenCorrectString_ShouldReturnReversedString()
        {
            // Arrange
            var input = "hello world";
            var expectedOutput = "dlrow olleh";
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseWhile(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ReverseStrUseFor_GivenNumbers_ShouldReturnReversedString()
        {
            // Arrange
            var input = "123123134534 3453 35 3";
            var expectedOutput = input.Reverse();
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseWhile(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ReverseStrUseFor_GivenNumbersAndLetters_ShouldReturnReversedString()
        {
            // Arrange
            var input = "  Hello 123123 wold233d!!";
            var expectedOutput = input.Reverse();
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseWhile(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ReverseStrUseFor_GivenSpaces_ShouldReturnString()
        {
            // Arrange
            var input = "                 ";
            var expectedOutput = input;
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseWhile(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ReverseStrUseWhile_WhenGivenEmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            var input = string.Empty;
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseWhile(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ReverseStrUseFor_WhenGivenNull_ShouldReturnNull()
        {
            // Arrange
            string input = null;
            var stringReverse = new Reverse();

            // Act
            var result = stringReverse.ReverseStrUseFor(input);

            // Assert
            Assert.Null(result);
        }
    }
}