using Memorabilia.Domain.Interfaces;

namespace Memorabilia.Domain.Constants;

public abstract class DomainItemConstants(int id, string name, string abbreviation = null) 
    : IWithName, IWithValue<int>
{
    public string Abbreviation { get; } 
        = abbreviation;

    public int Id { get; } 
        = id;

    public string Name { get; } 
        = name;

    public int Value 
        => Id;

    public override string ToString()
        => Name;
}
