using System.Collections.Generic;

using Xunit;

namespace YahtzeeTDD.Tests
{
    public class ScoreManagerTest
    {
        #region OnesTest

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

        #endregion OnesTest

        #region TwosTest

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

        [Fact]
        public void Should_Not_Add_Twos_Score()
        {
            // Arrange
            var dicesValues = new List<int> { 3, 1, 4, 3, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Twos();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion TwosTest

        #region ThreesTest

        [Fact]
        public void Should_Add_Threes_Score_Once()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Threes();

            // Assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Should_Add_Threes_Score_MultipleTimes()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 3, 3, 3, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Threes();

            // Assert
            Assert.Equal(9, actual);
        }

        [Fact]
        public void Should_Not_Add_Threes_Score()
        {
            // Arrange
            var dicesValues = new List<int> { 2, 1, 4, 6, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Threes();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion ThreesTest

        #region FoursTest

        [Fact]
        public void Should_Add_Fours_Score_Once()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Fours();

            // Assert
            Assert.Equal(4, actual);
        }

        [Fact]
        public void Should_Add_Fours_Score_MultipleTimes()
        {
            // Arrange
            var dicesValues = new List<int> { 4, 3, 4, 3, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Fours();

            // Assert
            Assert.Equal(8, actual);
        }

        [Fact]
        public void Should_Not_Add_Fours_Score()
        {
            // Arrange
            var dicesValues = new List<int> { 2, 1, 6, 6, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Fours();

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion FoursTest

        #region FoursTest

        [Fact]
        public void Should_Add_Fives_Score_Once()
        {
            // Arrange
            var dicesValues = new List<int> { 1, 2, 3, 4, 5 };
            var scoreManager = new ScoreManager(dicesValues);

            // Act
            var actual = scoreManager.Fives();

            // Assert
            Assert.Equal(5, actual);
        }

        #endregion FoursTest
    }
}