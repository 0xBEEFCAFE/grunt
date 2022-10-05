﻿// <copyright file="Sprite.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Individual sprite configuration. Mostly used for medals.
    /// </summary>
    public class Sprite
    {
        /// <summary>
        /// Gets or sets the path to the sprite.
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        /// Gets or sets the number of columns for the sprite.
        /// </summary>
        public int Columns { get; set; }

        /// <summary>
        /// Gets or sets the size, in pixels, for component images.
        /// </summary>
        public int Size { get; set; }
    }
}
