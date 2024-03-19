namespace Todo.Domain;

public abstract class ValueObject: IEquatable<ValueObject>
{

    public static bool operator ==(ValueObject left, ValueObject right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !Equals(left, right);
    }

    public abstract IEnumerable<object> GetQualityComponents();
    public bool Equals(ValueObject? other)
    {
        return Equals((object?)other);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
            return false;
        var valueObject = (ValueObject)obj;
        return GetQualityComponents().SequenceEqual(valueObject.GetQualityComponents());
    }

    public override int GetHashCode()
    {
        return GetQualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }
}