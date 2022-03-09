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
            var score = 0;

            foreach (var value in DicesValues)
            {
                if (value == 2)
                {
                    score += 2;
                }
            }

            return score;
        }
    }
}