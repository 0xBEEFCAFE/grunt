﻿// <copyright file="MatchInfo.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Container for general match information.
    /// </summary>
    [IsAutomaticallySerializable]
    public class MatchInfo
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public LifecyleMode LifecycleMode { get; set; }
        public GameVariantCategory? GameVariantCategory { get; set; }
        public Guid LevelId { get; set; }
        public GenericAsset MapVariant { get; set; }
        public UGCGameVariant UgcGameVariant { get; set; }
        public Guid ClearanceId { get; set; }
        public GenericAsset? Playlist { get; set; }
        public PlaylistExperience? PlaylistExperience { get; set; }
        public GenericAsset? PlaylistMapModePair { get; set; }
        public string SeasonId { get; set; }
        public TimeSpan PlayableDuration { get; set; }
        public bool TeamsEnabled { get; set; }
        public bool TeamScoringEnabled { get; set; }
    }

}
