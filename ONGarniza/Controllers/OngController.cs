using Microsoft.AspNetCore.Mvc;
using ONGarniza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONGarniza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OngController : ControllerBase
    {
        private static List<Ong> ongs = new List<Ong>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaOng([FromBody] Ong ong)
        {
            ong.Id = id++;
            ongs.Add(ong);
            return CreatedAtAction(nameof(RecuperaEventoPorId), new { Id = ong.Id }, ong);
        }

        [HttpGet]
        public IActionResult RecuperaOng()
        {
            return Ok(ongs);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEventoPorId(int id)
        {
            Ong ong = ongs.FirstOrDefault(ong => ong.Id == id);
            if(ong != null)
            {
                return Ok(ong);
            }
            return NotFound();
        }
    }
}
