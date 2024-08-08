using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace FXOpenAPI.API.Controllers
{
    public class CurrenciesController : BaseController
    {
        private readonly ILogger<CurrenciesController> _logger;
        private static HttpClient _client = new HttpClient();

        public CurrenciesController(ILogger<CurrenciesController> logger) : base()
        {
            _logger = logger;
            _client.BaseAddress = new Uri(ApiStrings.BaseUrl);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                BasicAuthentication.ConvertToSting(Credentials.ID, Credentials.Key, Credentials.Secret));
        }

        [HttpGet("/Symbol/{symbol}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Currency))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBySymbol(string symbol, CancellationToken token)
        {
            var response = await _client.GetFromJsonAsync<Currency>($"{ApiStrings.Currency}/{symbol}", token);

            if (response == null) return NotFound();

            _logger.LogInformation("Currency request successfully.");

            return Ok(response!);
        }

        [HttpGet("/CurrencyType/List")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CurrencyType>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ListCurrencyType(string symbol, CancellationToken token)
        {
            var response = await _client.GetFromJsonAsync<CurrencyType>(ApiStrings.CurrencyType, token);

            if (response == null) return NotFound();

            _logger.LogInformation("CurrencyType request successful.");

            return Ok(response!);
        }

        [HttpGet("/List")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Currency>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ListCurrency(CancellationToken token)
        {
            var response = await _client.GetFromJsonAsync<List<Currency>>(ApiStrings.Currency, token);

            if (response == null) return NotFound();

            _logger.LogInformation("CurrencyType request successful.");

            return Ok(response!);
        }

        [HttpGet("/Symbol/List")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SymbolList>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ListSymbol(CancellationToken token)
        {
            var response = await _client.GetFromJsonAsync<List<SymbolList>>(ApiStrings.Symbols, token);

            if (response == null) return NotFound();

            _logger.LogInformation("Symbol Lists request successful.");

            return Ok(response!);
        }
    }
}
