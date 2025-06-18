using Microsoft.AspNetCore.Mvc;
using Transplante.Application.DTOs;
using Transplante.Application.Facade;
using Transplante.Domain.Entities;

namespace Transplante.API.Controllers
{
    [Route("[controller]")]
    public class DadosVitaisController : ControllerBase
    {
        private IDadosVitaisFacade IDadosFacade;
        public DadosVitaisController(IDadosVitaisFacade iDadosFacade)
        {
            IDadosFacade = iDadosFacade;
        }

        [HttpGet]
        public List<DadosVitais> FindDadosVita()
            => IDadosFacade.FindDados();

        [HttpPost("saveDadosVitais")]
        public DadosVitais SaveDadosVitais([FromBody]DadosSaudeDTO dto)
            => IDadosFacade.SaveDadosVitais(dto);
    }
}
