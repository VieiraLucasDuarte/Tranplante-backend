using Transplante.Application.DTOs;
using Transplante.Domain.Entities;

namespace Transplante.Application.Facade
{
    public interface IDadosVitaisFacade
    {
        DadosVitais SaveDadosVitais(DadosSaudeDTO dados);
        List<DadosVitais> FindDados();
    }
}
