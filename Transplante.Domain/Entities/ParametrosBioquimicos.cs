namespace Transplante.Domain.Entities
{
    public class ParametrosBioquimicos
    {
        public int Id { get; set; }
        public DateTime DataExame { get; set; }
        public string Transplante { get; set; }
        public string Exames { get; set; }
        public int IdPessoa { get; set; }
    }
}
 