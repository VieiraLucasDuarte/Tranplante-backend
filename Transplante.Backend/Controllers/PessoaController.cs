using Microsoft.AspNetCore.Mvc;

namespace Transplante.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet("Find")]
        public void Find()
        {

        }
    }
}
