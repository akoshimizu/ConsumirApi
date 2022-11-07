using ConsumirApi.Entidade;
using ConsumirApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsumirApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MesaController : ControllerBase
    {
        private readonly IMesaServices _mesaServices;
        public MesaController(IMesaServices mesaServices)
        {
            _mesaServices = mesaServices;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarMesas()
        {
            var mesasLocalizadas = await _mesaServices.BuscarMesas();
            return Ok(mesasLocalizadas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> BuscarMesaPorId(int id)
        {
            var mesaLocalizada = await _mesaServices.BuscarMesaPorId(id);
            return Ok(mesaLocalizada);
        }

        [HttpPost]
        public async Task<ActionResult> CriarMesa([FromBody] Mesa mesa)
        {
            var novaMesa = await _mesaServices.CriarMesa(mesa);
            return Ok(novaMesa);
        }
    }
}