using Catalogo.Domain.Validation;

namespace Catalogo.Domain.Entities;

public class Entity
{
    public int Id { get; protected set; }

    public Entity(int id)
    {
        DomainExceptionValidation.When(id < 0, $"Valor de Id (${ id }) inválido");
        Id = id;
    }
}
