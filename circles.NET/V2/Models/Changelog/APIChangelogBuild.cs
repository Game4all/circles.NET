using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace circles.NET.V2.Models.Changelog
{
    /// <summary>
    /// A changelog for a specific build.
    /// </summary>
    public class APIChangelogBuild
    {
        /// <summary>
        /// The ID of this build changelog.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The version of this build changelog.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// The user-displayable version of this build changelog.
        /// </summary>
        [JsonProperty("display_version")]
        public string DisplayVersion { get; set; }

        /// <summary>
        /// Number of players playing on this actual build.
        /// </summary>
        [JsonProperty("users")]
        public long Users { get; set; }

        /// <summary>
        /// The date at which the build was published.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The <see cref="APIUpdateStream"/> of this build changelog.
        /// </summary>
        [JsonProperty("update_stream")]
        public APIUpdateStream UpdateStream { get; set; }

        /// <summary>
        /// The changelog entries for this build changelog.
        /// </summary>
        [JsonProperty("changelog_entries")]
        public List<APIChangelogEntry> ChangelogEntries { get; set; }
    }
}