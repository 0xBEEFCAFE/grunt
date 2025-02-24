﻿// <copyright file="TestDrillCategory.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System.Collections.Generic;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Category associated with academy test drill.
    /// </summary>
    [IsAutomaticallySerializable]
    public class TestDrillCategory
    {
        /// <summary>
        /// Gets or sets the drill type.
        /// </summary>
        public string? DrillType { get; set; }

        /// <summary>
        /// Gets or sets the list of associated drills.
        /// </summary>
        public List<AcademyDrill>? Drills { get; set; }
    }
}
