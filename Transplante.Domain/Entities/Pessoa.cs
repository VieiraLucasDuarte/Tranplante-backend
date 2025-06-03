using System.ComponentModel.DataAnnotations;

namespace Transplante.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
