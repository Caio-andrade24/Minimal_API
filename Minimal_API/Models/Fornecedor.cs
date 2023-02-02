namespace Minimal_API.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public String? Nome { get; set; }
        public string? Documento { get; set;}
        public bool Ativo { get; set;}  
    }
}
