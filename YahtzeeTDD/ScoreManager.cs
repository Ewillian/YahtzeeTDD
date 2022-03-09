using System.Collections.Generic;

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
            var score = 0;

            foreach (var value in DicesValues)
            {
                if (value == 1)
                {
                    score += 1;
                }
            }

            return score;
        }
    }
}