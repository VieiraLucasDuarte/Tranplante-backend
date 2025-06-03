namespace Transplante.Domain.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string NomeMedico { get; set; }
        public string ObservacoesMedicas { get; set; }
        public int Presenca { get; set; }
        public int IdPessoa { get; set; }
    }
}
