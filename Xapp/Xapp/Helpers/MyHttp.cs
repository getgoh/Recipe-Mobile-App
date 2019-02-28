using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Xapp.Helpers
{
    public class MyHttp<T>
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<string> Get(string queryString)
        {
            string authUserName = "user";
            string authPassword = "password";
            string url = "http://127.0.0.1:5000";

            // If you do not have basic authentication, you may skip these lines
            //var authToken = Encoding.ASCII.GetBytes($"{authUserName}:{authPassword}");
            //_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

            // The actual Get method
            using (var result = await _httpClient.GetAsync($"{url}{queryString}"))
            {
                string content = await result.Content.ReadAsStringAsync();
                return content;
            }
        }

        public static async Task<string> Post(T obj)
        {
            string url = "http://10.0.1.34:5000";

            var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            // The actual Post method
            using (var result = await _httpClient.PostAsync(url, stringContent))
            {
                string content = await result.Content.ReadAsStringAsync();
                return content;
            }
        }
    }
}
