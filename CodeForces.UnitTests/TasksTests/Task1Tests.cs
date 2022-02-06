using CodeForces.Tasks;
using CodeForces.UnitTests.Suts;
using Xunit;

namespace CodeForces.UnitTests.TasksTests
{
    public class Task1Tests
    {
        private readonly Task1 _task1;

        public Task1Tests()
        {
            _task1 = Task1Sut.CreateTask1();
        }

        [Fact]
        public void Execute_WhenPassingCorrectParameters_ThenShouldReturnCorrectValues()
        {
            // Arrange
            const int a = 1;
            const int b = 2; 
            const int expectedResult = 3;

            // Act
            var actualResult = _task1.Execute(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void CanAddTheory(int a, int b, int expectedResult)
        {
            // Arrange

            // Act
            var actualResult = _task1.Execute(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}