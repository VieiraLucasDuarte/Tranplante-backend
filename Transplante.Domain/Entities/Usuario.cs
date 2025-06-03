namespace Transplante.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UsuarioName { get; set; }
        public string Senha { get; set; }
        public int IdPessoa { get; set; }
    }
}
