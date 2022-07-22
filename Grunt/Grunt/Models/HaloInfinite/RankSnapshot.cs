﻿namespace Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class RankSnapshot
    {
        public int Rank { get; set; }
        public RewardContainer FreeRewards { get; set; }
        public RewardContainer PaidRewards { get; set; }
    }
}
