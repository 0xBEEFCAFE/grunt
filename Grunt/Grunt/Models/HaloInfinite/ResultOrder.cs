﻿// <copyright file="ResultOrder.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Determines how results in an API call that returns multiple entities are ordered.
    /// </summary>
    public enum ResultOrder
    {
        /// <summary>
        /// Show results in descending order.
        /// </summary>
        Desc,

        /// <summary>
        /// Show results in ascending order.
        /// </summary>
        Asc,
    }
}
