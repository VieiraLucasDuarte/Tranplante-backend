namespace Transplante.Domain.Entities
{
    public class Medicacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Horario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Arquivo { get; set; }
        public int IdPessoa { get; set; }
    }
}
