﻿// <copyright file="GenericAsset.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using OpenSpartan.Grunt.Models.HaloInfinite.Foundation;

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Generic representation of a game asset, implemented through <see cref="AssetBase"/>.
    /// </summary>
    [IsAutomaticallySerializable]
    public class GenericAsset : AssetBase
    {
    }
}
