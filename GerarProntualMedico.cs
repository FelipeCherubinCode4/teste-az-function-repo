using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace VollMed.FunctionApp;

public class GerarProntualMedico
{
    private readonly ILogger<GerarProntualMedico> _logger;

    public GerarProntualMedico(ILogger<GerarProntualMedico> logger)
    {
        _logger = logger;
    }

    [Function("GerarProntuarioMedico")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}