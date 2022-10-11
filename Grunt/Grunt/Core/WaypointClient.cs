﻿// <copyright file="WaypointClient.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using OpenSpartan.Grunt.Core.Foundation;
using OpenSpartan.Grunt.Endpoints;
using OpenSpartan.Grunt.Models;
using OpenSpartan.Grunt.Models.Waypoint;
using OpenSpartan.Grunt.Util;

namespace OpenSpartan.Grunt.Core
{
    /// <summary>
    /// Client for interacting with the Halo Waypoint APIs.
    /// </summary>
    public class WaypointClient : ClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaypointClient"/> class, used to access the Halo Waypoint API.
        /// </summary>
        /// <param name="spartanToken">The Spartan token used to authenticate against the Halo Infinite API.</param>
        /// <param name="xuid">The player identifier in the format "xuid(XUID_VALUE)".</param>
        /// <param name="clearanceToken">ID of the flight/clearance currently active for the player. Optional when first instantiating the client.</param>
        public WaypointClient(string spartanToken, string xuid = "", string clearanceToken = "")
        {
            this.SpartanToken = spartanToken;
            this.Xuid = xuid;
            this.ClearanceToken = clearanceToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaypointClient"/> class, used to access the Halo Waypoint API.
        /// </summary>
        public WaypointClient()
        {
        }

        /// <summary>
        /// Redeems a Halo Waypoint code.
        /// </summary>
        /// <remarks>
        /// The codes redeemable here can be those that are obtained through Xbox Game Pass perks, but can also be outside the scope of that particular program.
        /// </remarks>
        /// <include file='../APIDocsExamples/Waypoint/RedeemCode.xml' path='//example'/>
        /// <param name="code">Code to be redeemed.</param>
        /// <returns>If call is successful, returns an instance of <see cref="CodeRedemptionResult"/> that contains information about the redeemed code. Otherwise, returns a null object and error details.</returns>
        public async Task<HaloApiResultContainer<CodeRedemptionResult, HaloApiErrorContainer>> RedeemCode(string code)
        {
            RedeemableCode container = new()
            {
                Code = code,
            };

            return await this.ExecuteAPIRequest<CodeRedemptionResult>(
                $"https://{WaypointEndpoints.VoucherEndpoint}.{WaypointEndpoints.ServiceDomain}/users/me/codes",
                HttpMethod.Post,
                true,
                false,
                GlobalConstants.WEB_USER_AGENT,
                JsonSerializer.Serialize(container));
        }

        /// <summary>
        /// Gets information about a user's Halo Waypoint settings.
        /// </summary>
        /// <remarks>
        /// Settings are obtained for the user associated with the Spartan token passed to the request.
        /// </remarks>
        /// <include file='../APIDocsExamples/Waypoint/GetUserSettings.xml' path='//example'/>
        /// <returns>If successful, returns an instance of <see cref="UserSettings"/> containing user configuration information. Otherwise, returns a null object and error details.</returns>
        public async Task<HaloApiResultContainer<UserSettings, HaloApiErrorContainer>> GetUserSettings()
        {
            return await this.ExecuteAPIRequest<UserSettings>(
                $"https://{WaypointEndpoints.ProfileEndpoint}.{WaypointEndpoints.ServiceDomain}/users/me/settings",
                HttpMethod.Post,
                true,
                false,
                GlobalConstants.WEB_USER_AGENT);
        }
    }
}
