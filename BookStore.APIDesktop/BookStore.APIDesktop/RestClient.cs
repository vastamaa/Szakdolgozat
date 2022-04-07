using BookStore.APIDesktop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestAPI.ViewModels;

namespace BookStore.APIDesktop
{
    public static class RestClient
    {
        public static async Task<TokenModel> PostAsync(string url, LoginModel loginModel)
        {
            using (var client = new HttpClient())
            {
                var stringPayload = JsonConvert.SerializeObject(loginModel);

                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

                // Do the actual request and await the response
                var httpResponse = await client.PostAsync(url, httpContent);

                httpResponse.EnsureSuccessStatusCode();

                if (httpResponse.IsSuccessStatusCode)
                {
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TokenModel>(responseContent);
                }
                return null;
            }
        }

        public static async Task<List<BookWithEverythingVM>> GetAsync(string url, string token)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", token);
                var httpResponse = await client.GetStringAsync(url);
                System.Console.WriteLine(httpResponse);

                return JsonConvert.DeserializeObject<List<BookWithEverythingVM>>(httpResponse);
            }
        }
    }
}
