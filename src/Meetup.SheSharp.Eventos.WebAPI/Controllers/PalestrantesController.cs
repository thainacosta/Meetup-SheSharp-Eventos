using Meetup.SheSharp.Eventos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Meetup.SheSharp.Eventos.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalestrantesController : ControllerBase
    {
        public PalestranteRepository _palestranteRepositories;
        public PalestrantesController()
        {
            _palestranteRepositories = new PalestranteRepository();
        }
        // GET: api/Palestrante
        [HttpGet]
        public IEnumerable<Palestrante> Get()
        {
            return _palestranteRepositories.RetornaTudo();
        }

        // GET: api/Palestrante/5
        [HttpGet("{id}/skills", Name = "Get")]
        public IEnumerable<string> Get(int id)
        {
            Palestrante participante = _palestranteRepositories.RetornabyId(id);
            return participante.Skills;
        }

        // POST: api/Palestrante
        [HttpPost]
        public Palestrante Post([FromBody] Palestrante palestrante)
        {
            return _palestranteRepositories.AdicionarPalestrante(palestrante);
        }

        // PUT: api/Palestrante/5        [HttpPut("{id}")]
        public Palestrante Put(int id, [FromBody] Palestrante palestrante)
        {

            palestrante.Id = id;
            return _palestranteRepositories.AtualizaPalestrante(palestrante);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IList<Palestrante> Delete(int id)
        {
            return _palestranteRepositories.ExcluiPalestrante(id);
        }
    }
}
