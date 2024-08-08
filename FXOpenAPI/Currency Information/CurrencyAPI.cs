using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace FXOpenAPI.Currency_Information
{
    public class AccountAPI
    {
        public static HttpClient _client = new();

        public AccountAPI(string url, string id, string key, string secret)
        {
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthentication.ConvertToSting(id, key, secret));
        }

        // Gets Currency Information
        public async Task<Currency?> GetCurrency(string symbol)
        {
            var response = await _client.GetFromJsonAsync<Currency>($"{ApiStrings.Currency}/{symbol}");

            if (response == null) return null;

            return response;
        }

        // Gets All of Currency Type Information
        public async Task<List<CurrencyType>?> GetCurrencyTypes()
        {
            var response = await _client.GetFromJsonAsync<List<CurrencyType>>(ApiStrings.CurrencyType);

            if (response == null) return null;

            return response;
        }

        // Gets All of Currencies Information
        public async Task<List<Currency>> GetAllCurrencies()
        {
            var response = await _client.GetFromJsonAsync<List<Currency>>(ApiStrings.Currency);

            return response!;
        }
    }
}
