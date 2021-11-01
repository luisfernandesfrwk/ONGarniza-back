using Microsoft.AspNetCore.Mvc;
using ONGarniza.Models;
using System.Collections.Generic;
using System.Linq;

namespace ONGarniza.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EventoController : ControllerBase
    {
        private static List<Evento> eventos = new List<Evento>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaEvento([FromBody] Evento evento)
        {
            evento.Id = id++;
            eventos.Add(evento);
            return CreatedAtAction(nameof(RecuperaEventoPorId), new { Id = evento.Id }, evento);

        }

        [HttpGet]
        public IActionResult RecuperaEvento()
        {
            return Ok(eventos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEventoPorId()
        {
            Evento evento = eventos.FirstOrDefault(evento => evento.Id == id);
            if(evento != null)
            {
                return Ok(evento);
            }
            return NotFound();
        }
    }
}
