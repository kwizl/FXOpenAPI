﻿using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace FXOpenAPI.Quote_History.Information
{
    public class QuoteHistoryAPI
    {
        public static HttpClient _client = new();

        public QuoteHistoryAPI(string url, string id, string key, string secret)
        {
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", BasicAuthentication.ConvertToSting(id, key, secret));
        }

        // Geta All Symbols
        public async Task<List<string>?> GetSymbols()
        {
            var response = await _client.GetFromJsonAsync<List<string>>($"{ApiStrings.QuoteHistory}/{ApiStrings.Symbols}");

            if (response == null) return null;

            return response!;
        }

        // Get 1000 candlesticks of a currency based by TimeFrame
        public async Task<int?> GetInformation()
        {
            var response = await _client.GetFromJsonAsync<int?>($"{ApiStrings.QuoteHistory}/{ApiStrings.Version}");

            if (response == null) return null;

            return response!;
        }

        // Available TimeFrames for Candlesticks
        public async Task<List<string>?> GetSymbolPeriodicities(string symbol)
        {
            var response = await _client.GetFromJsonAsync<List<string>?>($"{ApiStrings.QuoteHistory}/{symbol}/{ApiStrings.Periodicities}");

            if (response == null) return null;

            return response!;
        }

        // Get Meta Information for Ask Symbol
        public async Task<QuoteHistoryBarsAskBidInfo?> GetSymbolPeriodicities(string symbol, string periodicity)
        {
            var response = await _client.GetFromJsonAsync<QuoteHistoryBarsAskBidInfo?>($"{ApiStrings.QuoteHistory}/{symbol}/{periodicity}/{ApiStrings.BarsAsk}/{ApiStrings.Info}");

            if (response == null) return null;

            return response!;
        }

        // Get Meta Information for BidSymbol
        public async Task<QuoteHistoryBarsAskBidInfo?> GetBidSymbolPeriodicities(string symbol, string periodicity)
        {
            var response = await _client.GetFromJsonAsync<QuoteHistoryBarsAskBidInfo?>($"{ApiStrings.QuoteHistory}/{symbol}/{periodicity}/{ApiStrings.BarsAsk}/{ApiStrings.Info}");

            if (response == null) return null;

            return response!;
        }

        // Get 1000 candlesticks of a currency based by TimeFrame and the ask price
        public async Task<List<QuoteHistoryBarsAsk>?> GetQuoteAsk(string symbol, string periodicity, Int64 timestamp, int count)
        {
            var response = await 
                _client.GetFromJsonAsync<List<QuoteHistoryBarsAsk>>($"{ApiStrings.QuoteHistory}/{symbol}/{periodicity}/{ApiStrings.BarsAsk}/{ApiStrings.Timestamp}={timestamp}&{ApiStrings.Count}={count}");

            if (response == null) return null;

            return response!;
        }

        // Get 1000 candlesticks of a currency based by TimeFrame and the bid price
        public async Task<List<QuoteHistoryBarsAsk>?> GetQuoteBid(string symbol, string periodicity, Int64 timestamp, int count)
        {
            var response = await 
                _client.GetFromJsonAsync<List<QuoteHistoryBarsAsk>>($"{ApiStrings.QuoteHistory}/{symbol}/{periodicity}/{ApiStrings.BarsBid}/{ApiStrings.Timestamp}={timestamp}&{ApiStrings.Count}={count}");

            if (response == null) return null;

            return response!;
        }

    }
}
