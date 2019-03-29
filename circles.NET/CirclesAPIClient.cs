using circles.NET.Exceptions;
using circles.NET.HTTP;
using System.Text;

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

        public CirclesAPIClient()
        {
            Client = new CirclesHttpClient(this);
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

        /// <summary>
        /// The defaut address to which API requests are made.
        /// <para>Override this if you need to pass API requests to eg: Ripple API</para>
        /// </summary>
        protected virtual string BaseEndpoint => $"https://osu.ppy.sh/api/";

        protected string CreateURL(string endpoint, params object[] parameters)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < parameters.Length; i += 2) //query strings are given this way [0] = QueryStringName, [1] = QueryStringValue
            {
                if (i == 0)
                {
                    sb.Append($"?{parameters[i].ToString()}={parameters[i + 1].ToString()}");
                    continue;
                }

                sb.Append($"&{parameters[i].ToString()}={parameters[i + 1].ToString()}");
            }

            return sb.ToString();
        }
    }
}