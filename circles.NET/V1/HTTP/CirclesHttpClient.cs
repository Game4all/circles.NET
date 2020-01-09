using circles.NET.V1.Exceptions;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace circles.NET.V1.HTTP
{
    /// <summary>
    /// A <see cref="HttpClient"/> with methods for deserializing directly API requests content into usable objects
    /// <para>Intended to be only used by <see cref="CirclesAPIClient"/></para>
    /// </summary>
    public sealed class CirclesHttpClient : HttpClient
    {
        public TraceListener DebugTrace { get; set; }

        internal CirclesHttpClient()
        {
        }

        internal CirclesHttpClient(HttpMessageHandler handler, bool disposeHandler)
            : base(handler, disposeHandler)
        {
        }

        public async Task<T> GetFromJSON<T>(string route)
        {
            DebugTrace?.WriteLine($"Requesting route: {route}");
            var request = await GetAsync(route);

            DebugTrace?.WriteLine($"Request at route \"{route}\" returned with status code {request.StatusCode}");

            if ((int)request.StatusCode == 401) //official osu! api returns a 401 error code when API key is invalid.
                throw new InvalidAPIKeyException();

            request.EnsureSuccessStatusCode();

            var content = await request.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}