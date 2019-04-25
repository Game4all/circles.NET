using circles.NET.Exceptions;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace circles.NET.HTTP
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

        public async Task<T> GetFromJSON<T>(string url)
        {
            DebugTrace?.WriteLine($"Requesting url: {url}");
            var request = await GetAsync(url);

            if ((int)request.StatusCode == 401) //official osu! api returns a 401 error code when API key is invalid.
                throw new InvalidAPIKeyException();

            request.EnsureSuccessStatusCode();
            DebugTrace?.WriteLine($"Request at {url} was sucessful");

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