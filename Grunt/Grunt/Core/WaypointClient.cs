﻿// <copyright file="WaypointClient.cs" company="Den Delimarsky">
// Developed by Den Delimarsky.
// Den Delimarsky licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// The underlying API powering Grunt is managed by 343 Industries and Microsoft. This wrapper is not endorsed by 343 Industries or Microsoft.
// </copyright>

using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Gets information about your own Halo Waypoint profile.
        /// </summary>
        /// <remarks>
        /// Profile is obtained for the user associated with the Spartan token passed to the request.
        /// </remarks>
        /// <include file='../APIDocsExamples/Waypoint/GetMyProfile.xml' path='//example'/>
        /// <returns>If successful, returns an instance of <see cref="UserProfile"/> containing profile information. Otherwise, returns a null object and error details.</returns>
        public async Task<HaloApiResultContainer<UserProfile, HaloApiErrorContainer>> GetMyProfile()
        {
            return await this.ExecuteAPIRequest<UserProfile>(
                $"https://{WaypointEndpoints.ProfileEndpoint}.{WaypointEndpoints.ServiceDomain}/users/me",
                HttpMethod.Post,
                true,
                false,
                GlobalConstants.WEB_USER_AGENT);
        }

        /// <summary>
        /// Gets information about a user's Halo Waypoint profile.
        /// </summary>
        /// <include file='../APIDocsExamples/Waypoint/GetUserProfile.xml' path='//example'/>
        /// <param name="userId">User identifier. Can be a XUID or Gamertag. If XUID is used, then <paramref name="isXuid"/> should be set to true.</param>
        /// <param name="isXuid">Determines whether the user ID specified in <paramref name="userId"/> is a XUID or not.</param>
        /// <returns>If successful, returns an instance of <see cref="UserProfile"/> containing profile information. Otherwise, returns a null object and error details.</returns>
        public async Task<HaloApiResultContainer<UserProfile, HaloApiErrorContainer>> GetUserProfile(string userId, bool isXuid)
        {
            string composedId = isXuid ? $"xuid({userId})" : $"gt({userId})";

            return await this.ExecuteAPIRequest<UserProfile>(
                $"https://{WaypointEndpoints.ProfileEndpoint}.{WaypointEndpoints.ServiceDomain}/users/me/{composedId}",
                HttpMethod.Post,
                true,
                false,
                GlobalConstants.WEB_USER_AGENT);
        }

        /// <summary>
        /// Gets the list of articles published on <see href="https://www.halowaypoint.com/">Halo Waypoint</see>.
        /// </summary>
        /// <include file='../APIDocsExamples/Waypoint/GetArticles.xml' path='//example'/>
        /// <param name="language">Article language. Example value is "en".</param>
        /// <param name="offset">Offset (number of articles to skip) from which to start the query.</param>
        /// <param name="count">Number of articles to retrieve.</param>
        /// <param name="order">Order in which articles are returned. Example values are "asc" or "desc".</param>
        /// <param name="categories">List of categories for which to return the articles.</param>
        /// <returns>If successful, returns the list of articles, each represented as <see cref="Article"/>. Otherwise, returns the details about the error.</returns>
        public async Task<HaloApiResultContainer<List<Article>, HaloApiErrorContainer>> GetArticles(string language = "", int offset = -1, int count = -1, string order = "", List<int>? categories = null)
        {
            string urlBase = $"https://{WaypointEndpoints.WPContentEndpoint}.{WaypointEndpoints.ServiceDomain}/articles?";

            if (!string.IsNullOrWhiteSpace(language))
            {
                urlBase += $"lang={language}&";
            }

            if (offset > 0)
            {
                urlBase += $"offset={offset}&";
            }

            if (count > 0)
            {
                urlBase += $"count={count}&";
            }

            if (!string.IsNullOrWhiteSpace(order))
            {
                urlBase += $"order={order}&";
            }

            if (categories != null && categories.Count > 0)
            {
                urlBase += $"categories={string.Join(",", categories)}&";
            }

            return await this.ExecuteAPIRequest<List<Article>>(
                urlBase,
                HttpMethod.Get,
                true,
                false,
                GlobalConstants.WEB_USER_AGENT);
        }
    }
}
