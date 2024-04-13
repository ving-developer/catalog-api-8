using Catalogo.Domain.Validation;

namespace Catalogo.Domain.Entities;

public sealed class Categoria : Entity
{
    public string Nome { get; private set; }
    public string ImagemUrl { get; private set; }
    public ICollection<Produto> Produtos { get; set; }


    public Categoria(string nome, string imagemUrl) : base(0)
    {
        Nome = nome;
        ImagemUrl = imagemUrl;
        ValidateDomain(nome, imagemUrl);
    }

    public Categoria(int id, string nome, string imagemUrl) : base(id)
    {
        Id = id;
        Nome = nome;
        ImagemUrl = imagemUrl;
    }

    private void ValidateDomain(string nome, string imagemUrl)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome inválido. Nome é um campo obrigatório");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Url da imagem inválido. Url é um campo obrigatório");
        DomainExceptionValidation.When(nome.Length > 3, "Nome deve conter no mínimo 3 caracteres");
        DomainExceptionValidation.When(imagemUrl.Length > 5, "Url deve conter no mínimo 5 caracteres");
    }
}
