using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ST10300512_CLDVPOE
{
    public class StoreTableInfo
    {
        private readonly ILogger<StoreTableInfo> _logger;

        public StoreTableInfo(ILogger<StoreTableInfo> logger)
        {
            _logger = logger;
        }

        [Function("StoreTableInfo")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}