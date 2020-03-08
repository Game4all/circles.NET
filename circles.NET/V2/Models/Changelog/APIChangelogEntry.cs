using Newtonsoft.Json;
using System;

namespace circles.NET.V2.Models.Changelog
{
    /// <summary>
    /// A changelog entry of a <see cref="APIChangelogBuild"/>.
    /// </summary>
    public class APIChangelogEntry
    {
        /// <summary>
        /// The ID of this changelog entry.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The github repository on which the feature was added.
        /// </summary>
        [JsonProperty("repository")]
        public string Repository { get; set; }

        /// <summary>
        /// An associated github pull request id with which the feature was added.
        /// </summary>
        [JsonProperty("github_pull_request_id")]
        public long? GithubPullRequestId { get; set; }

        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The type of this changelog entry.
        /// </summary>
        [JsonProperty("type")]
        public ChangelogEntryType Type { get; set; }

        /// <summary>
        /// The category of this changelog entry.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The title of this changelog entry.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The HTML message attached to this changelog entry.
        /// </summary>
        [JsonProperty("message_html")]
        public string MessageHtml { get; set; }

        /// <summary>
        /// Whether this feature is a major change.
        /// </summary>
        [JsonProperty("major")]
        public bool Major { get; set; }

        /// <summary>
        /// The date at which this feature was added.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The github user who added the feature.
        /// </summary>
        [JsonProperty("github_user")]
        public APIChangelogUser GithubUser { get; set; }
    }

    public enum ChangelogEntryType
    {
        Add,
        Fix
    }
}