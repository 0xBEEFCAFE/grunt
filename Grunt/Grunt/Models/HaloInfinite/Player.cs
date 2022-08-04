// <copyright file="Player.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Represents a match player.
    /// </summary>
    [IsAutomaticallySerializable]
    public class Player
    {
        /// <summary>
        /// Player Xbox Live ID (XUID).
        /// </summary>
        public string PlayerId { get; set; }

        /// <summary>
        /// Player type
        /// </summary>
        public PlayerType PlayerType { get; set; }

        /// <summary>
        /// Attributes associated with the bot player. Only available if player is a bot.
        /// </summary>
        public BotAttributes BotAttributes { get; set; }

        /// <summary>
        /// ID of the team the player was last associated with.
        /// </summary>
        public int LastTeamId { get; set; }

        /// <summary>
        /// Match outcome associated with the player.
        /// </summary>
        public Outcome Outcome { get; set; }

        /// <summary>
        /// Player rank within the match.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets participation info for the player in a match.
        /// </summary>
        public ParticipationInfo ParticipationInfo { get; set; }

        /// <summary>
        /// Individual team stats associated with a player.
        /// </summary>
        public PlayerTeamStat[] PlayerTeamStats { get; set; }
    }
}
