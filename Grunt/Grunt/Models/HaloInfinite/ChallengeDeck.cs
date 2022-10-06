// <copyright file="AssignedDeck.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System.Collections.Generic;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class ChallengeDeck
    {
        public string? Id { get; set; }
        public string? Path { get; set; }
        public List<Challenge>? ActiveChallenges { get; set; }
        public List<Challenge>? UpcomingChallenges { get; set; }
        public APIFormattedDate? Expiration { get; set; }
        public List<Challenge>? CompletedChallenges { get; set; }
    }
}
