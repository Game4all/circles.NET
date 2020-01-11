using circles.NET.V2.HTTP;

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
        public const string API_V2_URL = "https://osu.ppy.sh/api/v2";

        /// <summary>
        /// Gets the underlying <see cref="CirclesOAuthClient"/> Http client backing this <see cref="CirclesAPIV2Client"/> instance
        /// </summary>
        public CirclesOAuthClient Client { get; }

        public CirclesAPIV2Client(string token)
        {
            Client = new CirclesOAuthClient()
            {
                OAuthToken = token
            };
        }
    }
}
