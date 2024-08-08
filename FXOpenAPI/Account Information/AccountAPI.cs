using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace FXOpenAPI.Account_Information
{
    public class AccountAPI
    {
        public static HttpClient _client = new();

        public AccountAPI(string url, string id, string key, string secret)
        {
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthentication.ConvertToSting(id, key, secret));
        }

        // Gets Account Information
        public async Task<Account> GetAccountInformation()
        {
            var response = await _client.GetFromJsonAsync<Account>(ApiStrings.Account);

            return response!;
        }
    }
}
