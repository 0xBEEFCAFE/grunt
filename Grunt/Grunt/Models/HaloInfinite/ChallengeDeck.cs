// <copyright file="AssignedDeck.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class ChallengeDeck
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public Challenge[] ActiveChallenges { get; set; }
        public Challenge[] UpcomingChallenges { get; set; }
        public APIFormattedDate Expiration { get; set; }
        public Challenge[] CompletedChallenges { get; set; }
    }
}
