using Newtonsoft.Json;
using System.Collections.Generic;

namespace circles.NET.V2.Models.Changelog
{
    /// <summary>
    /// A changelog data index returned from the API.
    /// </summary>
    public class APIChangelogIndex
    {
        /// <summary>
        /// The list of the latest changelog builds avalaibles.
        /// </summary>
        [JsonProperty]
        public List<APIChangelogBuild> Builds;

        /// <summary>
        /// The list of the avalaible update streams.
        /// </summary>
        [JsonProperty]
        public List<APIUpdateStream> Streams;
    }
}