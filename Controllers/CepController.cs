using consumirApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace consumirApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CepController : ControllerBase
{
    private ICepService _cepService;
    public CepController(ICepService cepService)
    {
        _cepService = cepService;
    }

    [HttpGet]
    public async Task<ActionResult> GetCep([FromQuery] string cep)
    {        var cepLocalizado = await _cepService.BuscaCepAsync(cep);
        return Ok(cepLocalizado);
    }
    
}
