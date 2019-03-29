using circles.NET.Enums;
using circles.NET.Exceptions;
using circles.NET.HTTP;
using circles.NET.Models;
using System;
using System.Text;
using System.Threading.Tasks;

namespace circles.NET
{
    /// <summary>
    /// An asynchronous client wrapper class for the osu! api v1
    /// </summary>
    public class CirclesAPIClient
    {
        /// <summary>
        /// Gets the underlying <see cref="CirclesHttpClient"/> Http client backing this <see cref="CirclesAPIClient"/> instance
        /// </summary>
        public CirclesHttpClient Client { get; }

        private CirclesAPIClient()
        {
            Client = new CirclesHttpClient(this);
        }

        public CirclesAPIClient(string apiKey)
            : this()
        {
            APIKey = apiKey;
        }

        /// <summary>
        /// Gets or sets the API Key for this <see cref="CirclesAPIClient"/> instance
        /// </summary>
        public string APIKey
        {
            get => ApiKey;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new InvalidAPIKeyException(value);
                ApiKey = value;
            }
        }

        protected string ApiKey;

        //GetUsersAsync overloads

        public async Task<APIUser[]> GetUsersAsync(string name) => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", name));

        public async Task<APIUser[]> GetUsersAsync(int id) => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", id, "type", "id"));

        public async Task<APIUser[]> GetUsersAsync(string name, Gamemode mode) => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", name, "m", (int)mode));

        public async Task<APIUser[]> GetUsersAsync(int id, Gamemode mode) => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", id, "m", (int)mode, "type", "id"));

        //GetScoresAsync overloads

        public async Task<APIScore[]> GetScoresAsync(int beatmapId) => await Client.GetFromJSON<APIScore[]>(CreateURL("get_scores", "k", APIKey, "b", beatmapId));

        /// <summary>
        /// The defaut address to which API requests are made.
        /// <para>Override this if you need to pass API requests to eg: Ripple API</para>
        /// </summary>
        protected virtual string BaseEndpoint => $"https://osu.ppy.sh/api/";

        /// <summary>
        /// Returns a complete URL to the API
        /// </summary>
        /// <param name="endpoint">The endpoint</param>
        /// <param name="queryStrings">The query strings</param>
        /// <returns></returns>
        protected string CreateURL(string endpoint, params object[] queryStrings)
        {
            var sb = new StringBuilder();
            sb.Append(BaseEndpoint);
            sb.Append(endpoint);

            for (int i = 0; i < queryStrings.Length; i += 2) //query strings are given this way [0] = QueryStringName, [1] = QueryStringValue
            {
                if (i == 0) //first parameter should always be API key
                {
                    sb.Append($"?{queryStrings[i].ToString()}={queryStrings[i + 1].ToString()}");
                    continue;
                }

                if (queryStrings[i + 1] != null) //if the query string value is != null , let's add it to the url
                    sb.Append($"&{queryStrings[i].ToString()}={queryStrings[i + 1].ToString()}");
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}