﻿// <copyright file="Result.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System.Collections.Generic;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Result associated with a matchmade game.
    /// </summary>
    [IsAutomaticallySerializable]
    public class Result
    {
        /// <summary>
        /// Gets or sets the team Matchmaking Rank (MMR).
        /// </summary>
        public double TeamMmr { get; set; }

        /// <summary>
        /// Gets or sets the rank recap, outlining the CSR progression.
        /// </summary>
        public RankRecap? RankRecap { get; set; }

        /// <summary>
        /// Gets or sets information regarding kill and death performance.
        /// </summary>
        public StatPerformances? StatPerformances { get; set; }

        /// <summary>
        /// Gets or sets the team ID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or sets the breakdown of team Machmaking Rank (MMR) values.
        /// </summary>
        public Dictionary<int, double>? TeamMmrs { get; set; }

        /// <summary>
        /// Gets or sets ranked rewards for a player as a result of the match.
        /// </summary>
        public RankedRewards? RankedRewards { get; set; }

        /// <summary>
        /// Gets or sets the match counterfactuals that map expected performance to actual performance.
        /// </summary>
        public Counterfactuals? Counterfactuals { get; set; }
    }
}
