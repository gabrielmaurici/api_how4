using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.ControllersEditarJogo
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        JogoRepository repository = new JogoRepository();

        [HttpPost("InserirJogo")]
        public void InserirJogo([FromBody] Jogo modelJogo)
        {
            repository.Create(modelJogo);
        }

        [HttpGet("ListarJogos")]
        public List<Jogo> ListarJogos()
        {
            return repository.Read();
        }

        [HttpGet("BuscarJogoPorId/{id}")]
        public Jogo BuscarJogoPorId(int id)
        {
            return repository.Read(id);
        }

        [HttpPut("EditarJogo")]
        public void EditarJogo([FromBody] Jogo model)
        {
            repository.Update(model);
        }

        [HttpDelete("DeletarJogo/{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
