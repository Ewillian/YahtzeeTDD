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
            return 1;
        }
    }
}