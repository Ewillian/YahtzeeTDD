using System.Collections.Generic;

using Xunit;

namespace YahtzeeTDD.Tests
{
    public class ScoreManagerTest
    {
        [Fact]
        public void Should_Add_Ones_Score_Once()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Ones();

            // Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Should_Add_Ones_Score_MultipleTimes()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 1, 1, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Ones();

            // Assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Should_Not_Add_Ones_Score()
        {
            // Arrange
            var dicesValues = new List<int> { 3, 2, 4, 3, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Ones();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Should_Add_Twos_Score_Once()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Twos();

            // Assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Should_Add_Twos_Score_MultipleTimes()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 1, 2, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Twos();

            // Assert
            Assert.Equal(4, actual);
        }
    }
}