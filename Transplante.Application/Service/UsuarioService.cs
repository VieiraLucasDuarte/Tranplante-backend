using Transplante.Application.DTOs;
using Transplante.Application.Facade;

namespace Transplante.Application.Service
{
    public class UsuarioService : IUsuarioFacade
    {
        public bool ValidarLogin(LoginDTO dto)
            => MockTesteLogin(dto);

        private bool MockTesteLogin(LoginDTO dto)
        {
            if (dto.Email == "lucas" && dto.Senha == "123")
                return true;
            else
                return false;
        }
    }
}
