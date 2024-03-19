using Todo.Domain.Entities;

namespace Todo.Domain;

public abstract class AggregateRoot<Tid>:Entity<Tid> where Tid : notnull
{
    protected AggregateRoot(Tid id) : base(id)
    {
    }
}