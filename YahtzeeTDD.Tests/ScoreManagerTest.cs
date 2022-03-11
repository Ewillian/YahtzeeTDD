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
        public void Should_Add_Three_Values_Three_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, firstFillValue, repeatedValue, secondFillValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 1)]
        public void Should_Add_Four_Values_Three_Of_A_Kind(int repeatedValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, repeatedValue, repeatedValue, fillValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void Should_Add_Five_Values_Three_Of_A_Kind(int repeatedValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, repeatedValue, repeatedValue, repeatedValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(3);

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
            var actual = scoreManager.OfAKind(3);

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
            var actual = scoreManager.OfAKind(3);

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion ThreeOfAKind

        #region FourOfAKind

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 1)]
        public void Should_Add_Four_Values_Four_Of_A_Kind(int repeatedValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, repeatedValue, repeatedValue, fillValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void Should_Add_Five_Values_Four_Of_A_Kind(int repeatedValue)
        {
            // Arrange
            var dicesValues = new List<int> { repeatedValue, repeatedValue, repeatedValue, repeatedValue, repeatedValue };
            var expected = dicesValues.Sum();

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(4);

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
        public void Should_Not_Add_One_Value_Four_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, repeatedValue, firstFillValue, secondFillValue, secondFillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(4);

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
        public void Should_Not_Add_Two_Values_Four_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, repeatedValue, firstFillValue, repeatedValue, secondFillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(4);

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
        public void Should_Not_Add_Three_Values_Four_Of_A_Kind(int repeatedValue, int firstFillValue, int secondFillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstFillValue, repeatedValue, repeatedValue, repeatedValue, secondFillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.OfAKind(4);

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion FourOfAKind

        #region FullHouse

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 1)]
        public void Should_Add_Values_Full_House(int pairValue, int threeOfAKindValue)
        {
            // Arrange
            var dicesValues = new List<int> { pairValue, threeOfAKindValue, pairValue, threeOfAKindValue, threeOfAKindValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.FullHouse();

            // Assert
            Assert.Equal(25, actual);
        }

        [Fact]
        public void Should_Not_Add_Values_Full_House()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.FullHouse();

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
        public void Should_Not_Pair_Add_Values_Full_House(int pairValue, int threeOfAKindValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { pairValue, threeOfAKindValue, fillValue, threeOfAKindValue, threeOfAKindValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.FullHouse();

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
        public void Should_Not_Triple_Add_Values_Full_House(int pairValue, int threeOfAKindValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { pairValue, fillValue, pairValue, threeOfAKindValue, threeOfAKindValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.FullHouse();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion FullHouse

        #region SmallStraight

        [Theory]
        [InlineData(1, 2, 3, 4, 6)]
        [InlineData(2, 3, 4, 5, 5)]
        [InlineData(3, 4, 5, 6, 1)]
        public void Should_Add_Values_Small_Straight(int firstValue, int secondValue, int thirdValue, int fourthValue, int fillValue)
        {
            // Arrange
            var dicesValues = new List<int> { firstValue, secondValue, thirdValue, fourthValue, fillValue };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.SmallStraight();

            // Assert
            Assert.Equal(30, actual);
        }

        [Fact]
        public void Should_Not_Add_Values_Small_Straight()
        {
            // Arrange
            var dicesValues = new List<int> { 2, 3, 5, 3, 5 };

            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.SmallStraight();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion SmallStraight
    }
}