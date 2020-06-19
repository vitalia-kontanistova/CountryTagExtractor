using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CountryTagExtractor
{
    static class HtmlLoader
    {
        static private HttpClient client;
        static string source = null;

        public static async Task<string> LoadAsync(string URL)
        {
            client = new HttpClient();

            var response = await client.GetAsync(URL);

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
