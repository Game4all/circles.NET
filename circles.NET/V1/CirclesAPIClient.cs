using circles.NET.V1.Enums;
using circles.NET.V1.Exceptions;
using circles.NET.V1.HTTP;
using circles.NET.V1.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace circles.NET.V1
{
    /// <summary>
    /// An asynchronous client wrapper class for the osu! api v1
    /// </summary>
    public class CirclesAPIClient
    {
        /// <summary>
        /// The https path to the official osu! api v1
        /// </summary>
        public const string API_V1_URL = "https://osu.ppy.sh/api/";

        /// <summary>
        /// Gets the underlying <see cref="CirclesHttpClient"/> Http client backing this <see cref="CirclesAPIClient"/> instance
        /// </summary>
        public CirclesHttpClient Client { get; }

        private CirclesAPIClient()
        {
            Client = new CirclesHttpClient();
            BaseEndpoint = new Uri(API_V1_URL);
        }

        /// <summary>
        /// Constructs an instance of <see cref="CirclesAPIClient"/> with the API key given as parameter
        /// </summary>
        /// <param name="apiKey"></param>
        public CirclesAPIClient(string apiKey)
            : this()
        {
            APIKey = apiKey;
        }

        /// <summary>
        /// Constructs an instance of <see cref="CirclesAPIClient"/> with the API key given as parameter and using the given <see cref="HttpMessageHandler"/> for handling http requests.
        /// Use this ctor if you need to implement request caching.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="handler">The <see cref="HttpMessageHandler"/> to use for this <see cref="CirclesAPIClient"/></param>
        /// <param name="DisposeHandler">Bool indicating if the attached <see cref="HttpMessageHandler"/> should be disposed on <see cref="CirclesAPIClient"/> disposal</param>
        public CirclesAPIClient(string apiKey, HttpMessageHandler handler, bool DisposeHandler = true)
        {
            APIKey = apiKey;
            Client = new CirclesHttpClient(handler, true);
            BaseEndpoint = new Uri(API_V1_URL);
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
                    throw new InvalidAPIKeyException();
                ApiKey = value;
            }
        }

        private string ApiKey;

        //GetUsersAsync overloads

        /// <summary>
        /// Gets a <see cref="APIUser[]"/> matching given parameters asynchronously
        /// </summary>
        /// <param name="name">The username to search for</param>
        /// <param name="mode">The gamemode</param>
        /// <returns></returns>
        public async Task<APIUser[]> GetUsersAsync(string name, Gamemode mode = Gamemode.Standard)
            => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", name, "m", (int)mode));

        /// <summary>
        /// Same as <see cref="GetUsersAsync(string, Gamemode)"/> but takes UserID instead of username
        /// </summary>
        /// <param name="name">The UserID to search for</param>
        /// <param name="mode">The gamemode (defaults to <see cref="Gamemode.Standard"/>)</param>
        public async Task<APIUser[]> GetUsersAsync(int id, Gamemode mode = Gamemode.Standard)
            => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", id, "m", (int)mode, "type", "id"));

        //GetScoresAsync overloads

        /// <summary>
        /// Gets a list of scores for the given beatmap id matching given parameters asynchronously
        /// </summary>
        /// <param name="beatmapId">The beatmap id to return scores from</param>
        /// <param name="username">The name of the user to return score from (<see cref="null"/> by default)</param>
        /// <param name="mode">The gamemode (defaults to <see cref="Gamemode.Standard"/>)</param>
        /// <param name="mods">A mods bitflag (defaults to null)</param>
        /// <param name="limit">A limit of results to return (returns first 500 results by default)</param>
        /// <returns></returns>
        public async Task<APIScore[]> GetScoresAsync(long beatmapId, string username = null, Gamemode mode = Gamemode.Standard, Mods? mods = null, int? limit = null)
            => await Client.GetFromJSON<APIScore[]>(CreateURL("get_scores", "k", APIKey, "b", beatmapId, "u", username, "m", (int)mode, "mods", (int?)mods, "limit", limit));

        //GetUserBestAsync overloads

        /// <summary>
        /// Gets a list of top plays for the given username asynchronously
        /// </summary>
        /// <param name="username">The username of the player to return top plays from</param>
        /// <param name="mode">The gamemode (defaults to <see cref="Gamemode.Standard"/>)</param>
        /// <param name="limit">A limit of results to return (returns first 500 results by default)</param>
        /// <returns></returns>
        public async Task<APIUserBest[]> GetUserBestAsync(string username, Gamemode mode = Gamemode.Standard, int? limit = null)
            => await Client.GetFromJSON<APIUserBest[]>(CreateURL("get_user_best", "k", APIKey, "u", username, "m", (int)mode, "limit", limit));

        //GetUserRecent overloads

        /// <summary>
        /// Gets a list of recent plays for the given username asynchronously
        /// </summary>
        /// <param name="username">The username of the player to return recent plays from</param>
        /// <param name="mode">The gamemode (defaults to <see cref="Gamemode.Standard"/>)</param>
        /// <param name="limit">A limit of results to return (returns first 500 results by default)</param>
        /// <returns></returns>
        public async Task<APIUserRecent[]> GetUserRecentAsync(string username, Gamemode mode = Gamemode.Standard, int? limit = null)
            => await Client.GetFromJSON<APIUserRecent[]>(CreateURL("get_user_recent", "k", APIKey, "u", username, "m", (int)mode, "limit", limit));

        //GetBeatmapsAsync overloads

        /// <summary>
        /// Gets a list of beatmaps matching the given mapsetId and parameters asynchronously
        /// </summary>
        /// <param name="mapset_id">The mapset id (required)</param>
        /// <param name="since"></param>
        /// <param name="creator"></param>
        /// <param name="gamemode"></param>
        /// <param name="includeConversions"></param>
        /// <param name="hash"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<APIBeatmap[]> GetBeatmapsByMapsetAsync(long? mapset_id = null, DateTime? since = null, string creator = null, Gamemode? gamemode = null, Conversions? includeConversions = null, string hash = null, int? limit = null)
            => await Client.GetFromJSON<APIBeatmap[]>(CreateURL("get_beatmaps", "k", APIKey, "since", since?.ToString("s"), "u", creator, "m", (int?)gamemode, "a", (int?)includeConversions, "h", hash, "s", mapset_id, "limit", limit));

        /// <summary>
        /// Gets a list of beatmaps matching the given beatmapId and parameters asynchronously
        /// </summary>
        /// <param name="beatmap_id"></param>
        /// <param name="since"></param>
        /// <param name="creator"></param>
        /// <param name="gamemode"></param>
        /// <param name="includeConversions"></param>
        /// <param name="hash"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public async Task<APIBeatmap[]> GetBeatmapsByIdAsync(long? beatmap_id = null, DateTime? since = null, string creator = null, Gamemode? gamemode = null, Conversions? includeConversions = null, string hash = null, int? limit = null)
            => await Client.GetFromJSON<APIBeatmap[]>(CreateURL("get_beatmaps", "k", APIKey, "since", since?.ToString("s"), "u", creator, "m", (int?)gamemode, "a", (int?)includeConversions, "h", hash, "b", beatmap_id, "limit", limit));

        //GetReplayAsync overloads

        /// <summary>
        /// Gets replay data from a specific play from a specific user asynchronously
        /// </summary>
        /// <param name="username"></param>
        /// <param name="beatmapId"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public async Task<APIReplay> GetReplayAsync(string username, long beatmapId, Gamemode mode)
            => await Client.GetFromJSON<APIReplay>(CreateURL("get_replay", "k", APIKey, "u", username, "b", beatmapId, "m", (int)mode));

        /// <summary>
        /// Gets data about a multiplayer room asynchronously
        /// </summary>
        /// <param name="roomId">The Room Id</param>
        /// <returns></returns>
        public async Task<APIMultiplayerRoom> GetMultiplayerRoomsAsync(long roomId)
            => await Client.GetFromJSON<APIMultiplayerRoom>(CreateURL("get_room", "k", APIKey, "mp", roomId));

        /// <summary>
        /// Performs a custom request against the given end_point with custom queryStrings
        /// <para>NOTE that the queryStrings already contains APIKey by default</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endPoint"></param>
        /// <param name="queryStrings"></param>
        /// <returns></returns>
        public async Task<T> GetRawAsync<T>(string endPoint, params object[] queryStrings)
            => await Client.GetFromJSON<T>(CreateURL(endPoint, "k", APIKey, queryStrings));

        /// <summary>
        /// The address of the API server to which API requests are made against.
        /// <para>Defaults to the official osu! v1 api server url</para>
        /// </summary>
        public Uri BaseEndpoint
        {
            get => Client.BaseAddress;
            set => Client.BaseAddress = value;
        }

        /// <summary>
        /// Returns a partial url to the given endpoint with the given query strings serialized into the url
        /// </summary>
        /// <param name="endpoint">The endpoint</param>
        /// <param name="queryStrings">The query strings</param>
        /// <returns></returns>
        protected string CreateURL(string endpoint, params object[] queryStrings)
        {
            var sb = new StringBuilder();
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
            return sb.ToString();
        }
    }
}