using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MenuWithSubMenu
{
    public static class RestClient
    {
        public static async Task<TReturn> MyPostAsync<TReturn, TParam>(string url, TParam var)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Globals.BaseUrl);

                var stringPayload = JsonConvert.SerializeObject(var);

                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

                // Do the actual request and await the response
                var httpResponse = await client.PostAsync(url, httpContent);

                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TReturn>(responseContent);
            }
        }

        public static async Task<T> MyGetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Globals.BaseUrl);

                client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", Globals.Token);
                var httpResponse = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<T>(httpResponse);
            }
        }

        public static async Task<T> MyDeleteAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Globals.BaseUrl);

                client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", Globals.Token);
                var httpResponse = await client.DeleteAsync(url);

                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseContent);
            }
        }

        public static async Task<TReturn> MyUpdateAsync<TReturn, TParam>(string url, TParam var)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Globals.BaseUrl);

                client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", Globals.Token);

                var stringPayload = JsonConvert.SerializeObject(var);

                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

                var httpResponse = await client.PutAsync(url, httpContent);

                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TReturn>(responseContent);
            }
        }
    }
}
