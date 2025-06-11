using Microsoft.AspNetCore.Mvc;
using Transplante.Application.DTOs;
using Transplante.Application.Facade;

namespace Transplante.API.Controllers
{
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioFacade IUsuarioFacade;
        public UsuarioController(IUsuarioFacade usuario)
        {
            this.IUsuarioFacade = usuario;
        }

        [HttpPost("login")]
        public bool ValidaLogin([FromBody]LoginDTO dto)
            => IUsuarioFacade.ValidarLogin(dto);

    }
}
