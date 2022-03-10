using System.Collections.Generic;

using Xunit;

namespace YahtzeeTDD.Tests
{
    public class ScoreManagerTest
    {
        #region MinorTypeTest

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 1)]
        public void Should_Add_Minor_Type_Score_Once(int targetValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { targetValue, fillValue, fillValue, fillValue, fillValue };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.SumSameValues(targetValue);

            // Assert
            Assert.Equal(targetValue, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 1)]
        public void Should_Add_Minor_Type_Score_MultipleTimes(int targetValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { targetValue, fillValue, targetValue, fillValue, fillValue };
            var scoreManager = new ScoreManager(dicesValues);

            var expected = targetValue * 2;

            // Act
            var actual = scoreManager.SumSameValues(targetValue);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 1)]
        [InlineData(6, 1, 2)]
        public void Should_Not_Add_Minor_Type_Score(int targetValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, firstFillValue, firstFillValue, secondFillValue, secondFillValue };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.SumSameValues(targetValue);

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion MinorTypeTest
    }
}