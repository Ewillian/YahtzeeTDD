using System.Collections.Generic;
using System.Linq;
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

        #region ThreeOfAKind

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 1)]
        [InlineData(6, 1, 2)]
        public void Should_Add_Values_Three_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, firstFillValue, repeatedValue, secondFillValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.ThreeOfAKind();

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
        public void Should_Not_Add_One_Value_Three_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, repeatedValue, firstFillValue, secondFillValue, secondFillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.ThreeOfAKind();

            // Assert
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(4, 5, 6)]
        [InlineData(5, 6, 1)]
        [InlineData(6, 1, 2)]
        public void Should_Not_Add_Two_Values_Three_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, repeatedValue, firstFillValue, repeatedValue, secondFillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.ThreeOfAKind();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion ThreeOfAKind
    }
}