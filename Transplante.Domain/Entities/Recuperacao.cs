namespace Transplante.Domain.Entities
{
    public class Recuperacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string ObservacoesMedidas { get; set; }
        public int IdPessoa { get; set; } 
    }
}
