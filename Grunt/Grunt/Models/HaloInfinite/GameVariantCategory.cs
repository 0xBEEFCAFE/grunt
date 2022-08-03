// <copyright file="MatchInfo.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Category a game variant falls into.
    /// </summary>
    public enum GameVariantCategory
    {
        /// <summary>
        /// Slayer
        /// </summary>
        MultiplayerSlayer = 6,

        /// <summary>
        /// Attrition
        /// </summary>
        MultiplayerAttrition = 7,

        /// <summary>
        /// Elimination
        /// </summary>
        MultiplayerElimination = 8,

        /// <summary>
        /// Fiesta
        /// </summary>
        MultiplayerFiesta = 9,

        /// <summary>
        /// Strongholds
        /// </summary>
        MultiplayerStrongholds = 11,

        /// <summary>
        /// King of the Hill
        /// </summary>
        MultiplayerBastion = 12,

        /// <summary>
        /// Total Control
        /// </summary>
        MultiplayerTotalControl = 14,

        /// <summary>
        /// Capture the Flag
        /// </summary>
        MultiplayerCtf = 15,

        /// <summary>
        /// Assault
        /// </summary>
        MultiplayerAssault = 16,

        /// <summary>
        /// Extraction
        /// </summary>
        MultiplayerExtraction = 17,

        /// <summary>
        /// Oddball
        /// </summary>
        MultiplayerOddball = 18,

        /// <summary>
        /// Stockpile
        /// </summary>
        MultiplayerStockpile = 19,

        /// <summary>
        /// Juggernaut
        /// </summary>
        MultiplayerJuggernaut = 20,

        /// <summary>
        /// VIP
        /// </summary>
        MultiplayerEscort = 23,

        /// <summary>
        /// Escalation
        /// </summary>
        MultiplayerGunGame = 24,

        /// <summary>
        /// Grifball
        /// </summary>
        MultiplayerGrifball = 25,

        /// <summary>
        /// Test game variant
        /// </summary>
        TestEngine = 32,

        /// <summary>
        /// Land Grab
        /// </summary>
        MultiplayerLandGrab = 39,
    }
}