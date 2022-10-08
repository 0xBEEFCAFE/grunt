﻿// <copyright file="Permission.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

namespace OpenSpartan.Grunt.Models.HaloInfinite
{
    /// <summary>
    /// Container for custom authoring permissions.
    /// </summary>
    [IsAutomaticallySerializable]
    public class Permission
    {
        /// <summary>
        /// Gets or sets the canonical token.
        /// </summary>
        public string? CanonicalToken { get; set; }

        /// <summary>
        /// Gets or sets the authoring role.
        /// </summary>
        public int AuthoringRole { get; set; }

        /// <summary>
        /// Gets or sets the grantor of permissions.
        /// </summary>
        public string? GrantedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the permissions were granted.
        /// </summary>
        public APIFormattedDate? GrantedOnDateUtc { get; set; }
    }
}
