namespace Transplante.Domain.Entities
{
    public class DadosVitais
    {
        public int Id { get; set; }
        public double PressaoArterial { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public double TemperaturaCorporal { get; set; }
        public double SaturacaoOxigenio { get; set; }
        public DateTime DataColeta { get; set; }
        public int IdPessoa { get; set; }
    }
}
