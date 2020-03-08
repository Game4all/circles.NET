using Newtonsoft.Json;

namespace circles.NET.V2.Models.Changelog
{
    /// <summary>
    /// Data about a user who contributed to a feature in a changelog entry.
    /// </summary>
    public class APIChangelogUser
    {
        /// <summary>
        /// The ID of this user.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The display name of the user.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// An url to the github profile of this user.
        /// </summary>
        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        /// <summary>
        /// The osu! username of this user.
        /// </summary>
        [JsonProperty("osu_username")]
        public string OsuUsername { get; set; }

        /// <summary>
        /// The user id of this user.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// An url to the osu! profile of this user.
        /// </summary>
        [JsonProperty("user_url")]
        public string UserUrl { get; set; }
    }
}