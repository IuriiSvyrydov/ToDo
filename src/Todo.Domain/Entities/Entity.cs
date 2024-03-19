using System.Runtime.Remoting;

namespace Todo.Domain.Entities;

public abstract class Entity<TId> where TId: notnull 
{
    public TId Id { get; protected set; }

    protected Entity(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
        => obj is Entity<TId> entity && Id.Equals(entity.Id);

    public static bool operator ==(Entity<TId> left, Entity<TId> right) => Equals(left, right);
    public static bool operator !=(Entity<TId> left, Entity<TId> right) => !Equals(left, right);
    public override int GetHashCode() => Id.GetHashCode();

}