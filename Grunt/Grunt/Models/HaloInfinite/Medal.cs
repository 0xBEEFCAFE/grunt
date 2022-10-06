// <copyright file="Medal.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class Medal
    {
        public long NameId { get; set; }

        public int Count { get; set; }

        public int TotalPersonalScoreAwarded { get; set; }

        public DisplayString? Name { get; set; }

        public DisplayString? Description { get; set; }

        public int SpriteIndex { get; set; }

        public int SortingWeight { get; set; }

        public int DifficultyIndex { get; set; }

        public int TypeIndex { get; set; }

        public int PersonalScore { get; set; }
    }
}
