using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaEntrevista.Services;
using PruebaEntrevista.Services.Interfaces;

namespace PruebaEntrevista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdivinanzaController : ControllerBase
    {
        private readonly IAdivinanzaService adivinanzaService;

        public AdivinanzaController(IAdivinanzaService adivinanzaService)
        {
            this.adivinanzaService = adivinanzaService;
        }

        [Route("Adivinar")]
        [HttpPost]
        public IActionResult AdivinarNumero([FromBody] int numeroIngresado) 
        {
            var mensaje = adivinanzaService.AdivinarNumero(numeroIngresado);
            return Ok(mensaje);
        }

        [Route("Reiniciar")]
        [HttpPost]
        public IActionResult ReiniciarJuego()
        {
            var mensaje = adivinanzaService.ReiniciarJuego();
            return Ok(mensaje);
        }
    }
}
