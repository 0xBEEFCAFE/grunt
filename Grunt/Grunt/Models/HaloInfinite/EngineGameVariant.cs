﻿// <copyright file="EngineGameVariant.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using OpenSpartan.Grunt.Models.HaloInfinite.Foundation;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Engine game variant.
    /// </summary>
    [IsAutomaticallySerializable]
    public class EngineGameVariant : AssetBase
    {
        /// <summary>
        /// Gets or sets custom data associated with an engine game variant.
        /// </summary>
        public EngineGameVariantCustomData? CustomData { get; set; }
    }
}
