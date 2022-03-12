using System.Collections.Generic;
using System.Linq;

namespace YahtzeeTDD
{
    public class ScoreManager
    {
        public List<int> DicesValues;

        #region Constructors

        public ScoreManager(List<int> dicesValues)
        {
            DicesValues = dicesValues;
        }

        #endregion

        #region Public methods

        public int SumSameValues(int targetValue)
        {
            return DicesValues.Where(value => value == targetValue).Sum(value => targetValue);
        }

        public int OfAKind(int ofAKindNumber)
        {
            for (var i = 1; i < 7; i++)
            {
                var count = DicesValues.Where(temp => temp.Equals(i))
                    .Select(temp => temp)
                    .Count();

                if (ofAKindNumber == 5 && count == 5)
                {
                    return 50;
                }

                if (count >= ofAKindNumber)
                {
                    return DicesValues.Sum();
                }
            }

            return 0;
        }

        public int FullHouse()
        {
            if (IsPresent(3) && IsPresent(2))
            {
                return 25;
            }

            return 0;
        }

        public int SmallStraight()
        {
            var combinationList = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4 },
                new List<int> { 2, 3, 4, 5 },
                new List<int> { 3, 4, 5, 6 }
            };

            DicesValues.Sort();

            return Straight(combinationList, 4) ? 30 : 0;
        }

        public int LargeStraight()
        {
            var combinationList = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5 },
                new List<int> { 2, 3, 4, 5, 6 }
            };

            DicesValues.Sort();

            return Straight(combinationList, 5) ? 40 : 0;
        }

        private bool Straight(IEnumerable<List<int>> combinationList, int expectCount)
        {
            return combinationList.Select(combinations => combinations.Count(w => DicesValues.Contains(w))).Any(count => count == expectCount);
        }

        public int Luck()
        {
            return DicesValues.Sum();
        }

        #endregion Public methods

        #region Private methods

        private bool IsPresent(int repetitionNumber)
        {
            for (var i = 1; i < 7; i++)
            {
                var count = DicesValues.Where(temp => temp.Equals(i))
                    .Select(temp => temp)
                    .Count();

                if (count == repetitionNumber)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion Private methods
    }
}