using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaEntrevista.Services.Interfaces;

namespace PruebaEntrevista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdivinanzaController : ControllerBase
    {
        private readonly IAdivinanzaService ejercicioService;

        public AdivinanzaController(IAdivinanzaService ejercicioService)
        {
            this.ejercicioService = ejercicioService;
        }

        [HttpPost]
        public ActionResult AdivinarNumero([FromBody] int numeroIngresado) 
        {
            var mensaje = ejercicioService.AdivinarNumero(numeroIngresado);
            return Ok(mensaje);
        }
    }
}
