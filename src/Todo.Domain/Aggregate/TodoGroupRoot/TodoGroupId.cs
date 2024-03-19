namespace Todo.Domain.Aggregate.TodoGroupRoot;

public class TodoGroupId: ValueObject
{
    public TodoGroupId(Guid value)
    {
        Value = value;
    }

    private TodoGroupId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public Guid Value { get; }
    public override IEnumerable<object> GetQualityComponents()
    {
        yield return Value;
    }
}