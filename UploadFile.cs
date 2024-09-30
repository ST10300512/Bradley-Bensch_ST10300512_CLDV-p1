using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;


namespace ST10300512_CLDVPOE
{
    public class UploadFile
    {
        private readonly ILogger<UploadFile> _logger;

        public UploadFile(ILogger<UploadFile> logger)
        {
            _logger = logger;
        }

        [Function("UploadFile")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
