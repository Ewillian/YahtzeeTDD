using System;
using System.Collections.Generic;
using System.Linq;

namespace YahtzeeTDD
{
    public class ScoreManager
    {
        public List<int> DicesValues;

        public ScoreManager(List<int> dicesValues)
        {
            DicesValues = dicesValues;
        }

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
    }
}