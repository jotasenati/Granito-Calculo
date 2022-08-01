using Domain.Interfaces.ICalculo;
using Microsoft.AspNetCore.Mvc;

namespace Granito_Calculo.Controllers;

[ApiController]
[Route("[api/controller]")]
public class CalculoController : ControllerBase
{
    private readonly ILogger<CalculoController> _logger;
    private readonly ICalculoTaxas _serviceCalculo;

    public CalculoController(ILogger<CalculoController> logger, ICalculoTaxas serviceCalculo)
    {
        _logger = logger;
        _serviceCalculo = serviceCalculo;
    }

    [HttpGet("/calcula-juros")]
    public async Task<IActionResult> Get([FromQuery] double valorInicial, [FromQuery] int meses)
    {
        return Ok(await Task.Run(() => _serviceCalculo.Calcula(valorInicial, meses)));
    }

    [HttpGet("/show-me-the-code")]
    public async Task<IActionResult> ShowCode()
    {
        return Ok(await Task.Run(() => _serviceCalculo.ShowCode()));
    }

}
