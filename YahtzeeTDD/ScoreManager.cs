﻿using System.Collections.Generic;
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
            var score = 0;

            foreach (var value in DicesValues)
            {
                if (value == 3)
                {
                    score += 3;
                }
            }

            return score;
        }
    }
}