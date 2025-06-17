namespace Transplante.Application.DTOs
{
    public class DadosSaudeDTO
    {
        public int IdPessoa { get; set; }
        public double PressaoArterial { get; set; }
        public int FrequenciaCardicacao { get; set; }
        public double TemperaturaCorporal { get; set; }
        public double SaturacaoOxigenio { get; set; }
        public double Peso { get; set; }
        public bool TomouRemedios { get; set; }
    }
}
