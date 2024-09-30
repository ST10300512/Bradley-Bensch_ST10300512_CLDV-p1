using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ST10300512_CLDVPOE
{
    public class ProcessQueueMessage
    {
        private readonly ILogger<ProcessQueueMessage> _logger;

        public ProcessQueueMessage(ILogger<ProcessQueueMessage> logger)
        {
            _logger = logger;
        }

        [Function("ProcessQueueMessage")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
