using Transplante.Application.DTOs;
using Transplante.Application.Facade;
using Transplante.Domain.Entities;

namespace Transplante.Application.Service
{
    public class DadosVitaisService : IDadosVitaisFacade
    {
        public DadosVitais SaveDadosVitais(DadosSaudeDTO dados)
        {
            return FindDados().FirstOrDefault();
        }
        public List<DadosVitais> FindDados()
        {
            return PreencheMock();
        }

        private static List<DadosVitais> PreencheMock()
        {
            return new List<DadosVitais>
        {

            new DadosVitais
            {
                Id = 1,
                PressaoArterial = 120.8,
                FrequenciaCardiaca = 72,
                TemperaturaCorporal = 36.7,
                SaturacaoOxigenio = 98.5,
                DataColeta = DateTime.Now.AddDays(-1),
                IdPessoa = 1001
            },
            new DadosVitais
            {
                Id = 2,
                PressaoArterial = 125.3,
                FrequenciaCardiaca = 78,
                TemperaturaCorporal = 37.0,
                SaturacaoOxigenio = 97.2,
                DataColeta = DateTime.Now.AddDays(-2),
                IdPessoa = 1002
            },
            new DadosVitais
            {
                Id = 3,
                PressaoArterial = 118.6,
                FrequenciaCardiaca = 69,
                TemperaturaCorporal = 36.5,
                SaturacaoOxigenio = 99.0,
                DataColeta = DateTime.Now.AddDays(-3),
                IdPessoa = 1003
            },
            new DadosVitais
            {
                Id = 4,
                PressaoArterial = 130.2,
                FrequenciaCardiaca = 85,
                TemperaturaCorporal = 37.3,
                SaturacaoOxigenio = 96.8,
                DataColeta = DateTime.Now.AddDays(-4),
                IdPessoa = 1004
            },
            new DadosVitais
            {
                Id = 5,
                PressaoArterial = 122.7,
                FrequenciaCardiaca = 75,
                TemperaturaCorporal = 36.8,
                SaturacaoOxigenio = 98.0,
                DataColeta = DateTime.Now.AddDays(-5),
                IdPessoa = 1005
            }
        };
        }
    }
}

