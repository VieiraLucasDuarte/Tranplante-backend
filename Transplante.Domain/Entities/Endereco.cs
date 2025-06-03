namespace Transplante.Domain.Entities
{
    public class Endereco
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public int IdPessoa { get; set; }
    }
}
