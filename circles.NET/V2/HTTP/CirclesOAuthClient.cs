using circles.NET.V2.Exceptions;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace circles.NET.V2.HTTP
{
    /// <summary>
    /// A <see cref="HttpClient"/> with methods for deserializing directly API requests content into usable objects
    /// Also handles OAuth login.
    /// <para>Intended to be only used by <see cref="CirclesAPIClient"/></para>
    /// </summary>
    public sealed class CirclesOAuthClient : HttpClient
    {
        public TraceListener DebugTrace { get; set; }

        internal string OAuthToken 
        { 
            set
            {
                DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", value);
            } 
        }

        internal CirclesOAuthClient()
        {
        }

        internal CirclesOAuthClient(HttpMessageHandler handler, bool disposeHandler) 
            : base(handler, disposeHandler)
        {
        }

        public async Task<T> GetFromJSON<T>(string route)
        {
            try
            {
                logTrace($"Requesting route: {route}");
                var request = await GetAsync(route);

                var content = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    logTrace($"Request at route \"{route}\" returned with status code {request.StatusCode}");

                    try
                    {
                        return JsonConvert.DeserializeObject<T>(content);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                } 
                else
                {
                    logTrace($"Request at route \"{route}\" returned with status code {request.StatusCode} and error body {content}");

                    if (request.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        throw new InvalidOAuthTokenException(); //we may want to add some additional info for the required oauth scopes

                    return default;
                }
            } 
            catch (Exception e)
            {
                throw e;
            }
        }

        [Conditional("DEBUG")]
        private void logTrace(string message) => DebugTrace?.WriteLine(message);
    }
}
