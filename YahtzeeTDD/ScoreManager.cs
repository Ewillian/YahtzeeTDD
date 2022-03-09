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

        public int Ones()
        {
            return DicesValues.Count(value => value == 1);
        }

        public int Twos()
        {
            return DicesValues.Where(value => value == 2).Sum(value => 2);
        }

        public int Threes()
        {
            return DicesValues.Where(value => value == 3).Sum(value => 3);
        }

        public object Fours()
        {
            return DicesValues.Where(value => value == 4).Sum(value => 4);
        }

        public object Fives()
        {
            return 5;
        }
    }
}