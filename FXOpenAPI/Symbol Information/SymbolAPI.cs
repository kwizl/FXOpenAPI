﻿using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace FXOpenAPI.Symbol_Information
{
    public class SymbolAPI
    {
        public static HttpClient _client = new();

        public SymbolAPI(string url, string id, string key, string secret)
        {
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthentication.ConvertToSting(id, key, secret));
        }

        public async Task<List<SymbolList>?> GetSymbols()
        {
            var response = await _client.GetFromJsonAsync<List<SymbolList>>(ApiStrings.Symbols);

            if (response == null) return null;

            return response;
        }
    }
}
