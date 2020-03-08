﻿using circles.NET.V2.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace circles.NET.V2.HTTP
{
    /// <summary>
    /// A <see cref="HttpClient"/> with methods for deserializing directly API requests content into usable objects
    /// Also handles OAuth login.
    /// <para>Intended to be only used by <see cref="CirclesAPIV2Client"/></para>
    /// </summary>
    internal sealed class CirclesOAuthClient : HttpClient
    {
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

        /// <summary>
        /// Performs a GET request asynchronously against the specified api route and deserializes the request reponse to an object of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route"></param>
        /// <returns></returns>
        public async Task<T> GetFromJSON<T>(string route)
        {
            try
            {
                debug($"Requesting route: {route}");
                var request = await GetAsync(route);

                var content = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    debug($"Request at route \"{route}\" returned with status code {request.StatusCode}");

                    try
                    {
                        return JsonConvert.DeserializeObject<T>(content);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                else
                {
                    debug($"Request at route \"{route}\" returned with status code {request.StatusCode} and error body {content}");

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

        private void debug(string str)
        {
            Console.Write("[circles.NET] ");
            Console.WriteLine(str);
        }
    }
}