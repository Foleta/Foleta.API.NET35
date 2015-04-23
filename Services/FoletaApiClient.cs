using System.Net;
using Newtonsoft.Json;

namespace Foleta.API.NET35
{
    /// <summary>
    /// Client to connect to Foleta API.
    /// </summary>
    public class FoletaApiClient
    {
        /// <summary>
        /// The base address
        /// </summary>
        private readonly string _apiAddress;


        /// <summary>
        /// The base address
        /// </summary>
        private readonly string _apiKey;


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiAddress"></param>
        /// <param name="apiKey"></param>
        public FoletaApiClient(string apiAddress, string apiKey)
        {
            _apiAddress = apiAddress;
            _apiKey = apiKey;
        }


        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public TResponse Get<TResponse>(string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("ContentType", "application/json");
            client.Headers.Add("X-Foleta-ApiKey", _apiKey);

            string response = client.DownloadString(_apiAddress + url);

            return JsonConvert.DeserializeObject<TResponse>(response);
        }
    }
}
