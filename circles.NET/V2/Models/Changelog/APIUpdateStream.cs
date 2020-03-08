using Newtonsoft.Json;

namespace circles.NET.V2.Models.Changelog
{
    /// <summary>
    /// Data about a specific update stream.
    /// </summary>
    public class APIUpdateStream
    {
        /// <summary>
        /// The ID of this update stream.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The internal name for this update stream.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The user-displayable name for this update stream.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The number of players which are currently playing on this update stream.
        /// </summary>
        [JsonProperty("users")]
        public long Users { get; set; }

        /// <summary>
        /// The latest build changelog avalaible for this update stream.
        /// </summary>
        [JsonProperty("latest_build")]
        public APIChangelogBuild LatestBuild { get; set; }
    }
}