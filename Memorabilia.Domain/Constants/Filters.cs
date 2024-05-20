namespace Memorabilia.Domain.Constants;

public abstract class Filters<T>
{
    public virtual string Name { get; private init; }

    protected Filters(string name)
    {
        Name = name;
    }

    public override string ToString()
        => Name;
}
