using circles.NET.V2.HTTP;
using System.Net.Http;

namespace circles.NET.V2
{
    /// <summary>
    /// An asynchronous client wrapper class for the osu! api v2
    /// </summary>
    public class CirclesAPIV2Client
    {
        /// <summary>
        /// The https path to the official osu! api v2
        /// </summary>
        public const string API_V2_URL = "https://osu.ppy.sh/api/v2/";

        private CirclesOAuthClient client;

        /// <summary>
        /// Constructs an instance of <see cref="CirclesAPIV2Client"/> using the specified OAuth token
        /// </summary>
        /// <param name="token">The osu!api v2 OAuth token</param>
        public CirclesAPIV2Client(string token)
        {
            client = new CirclesOAuthClient
            {
                OAuthToken = token,
                BaseAddress = new System.Uri(API_V2_URL)
            };
        }

        /// <summary>
        /// Constructs an instance of <see cref="CirclesAPIV2Client"/> using the specified OAuth token, the specified <see cref="HttpMessageHandler"/>
        /// </summary>
        /// <param name="token">The osu!api v2 OAuth token</param>
        /// <param name="handler">The <see cref="HttpMessageHandler"/> to use with this <see cref="CirclesAPIV2Client"/></param>
        /// <param name="disposeHandler">Whether to dispose the <see cref="HttpMessageHandler"/></param>
        public CirclesAPIV2Client(string token, HttpMessageHandler handler, bool disposeHandler)
        {
            client = new CirclesOAuthClient(handler, disposeHandler)
            {
                OAuthToken = token,
                BaseAddress = new System.Uri(API_V2_URL)
            };
        }
    }
}
