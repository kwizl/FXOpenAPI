using FXOpenAPI.Data.Models;
using FXOpenAPI.Logic.Extensions;
using FXOpenAPI.Logic.StaticStrings;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace FXOpenAPI.API.Controllers
{
    public class AccountsController : BaseController
    {
        private readonly ILogger<AccountsController> _logger;
        private static HttpClient _client = new HttpClient();

        public AccountsController(ILogger<AccountsController> logger) : base()
        {
            _logger = logger; 
            _client.BaseAddress = new Uri(ApiStrings.BaseUrl);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", 
                BasicAuthentication.ConvertToSting(Credentials.ID, Credentials.Key, Credentials.Secret));
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Account))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAccount(CancellationToken token)
        {
            var response = await _client.GetFromJsonAsync<Account>(ApiStrings.Account, token);

            if (response == null) return NotFound();

            _logger.LogInformation("Account gotten successfully.");

            return Ok(response!);
        }
    }
}
