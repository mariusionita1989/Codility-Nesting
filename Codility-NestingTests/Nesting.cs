using Codility_Nesting;

namespace Codility_NestingTests
{
    public class SolutionTests
    {
        [Fact]
        public void ProperlyNestedString_Returns1()
        {
            // Arrange
            Solution solution = new Solution();
            string S = "(()(())())";

            // Act
            int result = solution.solution(S);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ImproperlyNestedString_Returns0()
        {
            // Arrange
            Solution solution = new Solution();
            string S = "())";

            // Act
            int result = solution.solution(S);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void EmptyString_Returns1()
        {
            // Arrange
            Solution solution = new Solution();
            string S = "";

            // Act
            int result = solution.solution(S);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void LargeInputString_Returns0()
        {
            // Arrange
            Solution solution = new Solution();
            string S = new string('(', Solution.RANGE_HIGHEST_VALUE + 1) + new string(')', Solution.RANGE_HIGHEST_VALUE + 1);

            // Act
            int result = solution.solution(S);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void InvalidInputSize_ReturnsNegative1()
        {
            // Arrange
            Solution solution = new Solution();
            string S = new string('(', Solution.RANGE_HIGHEST_VALUE + 2);

            // Act
            int result = solution.solution(S);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}