namespace Memorabilia.Domain.Constants;

public sealed class EditModeTypes
{
    public static readonly EditModeTypes Add = new(1, "Add");
    public static readonly EditModeTypes Update = new(2, "Edit");

    public static readonly EditModeTypes[] All =
    [
        Add,
        Update
    ];

    private EditModeTypes(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }

    public string Name { get; }
}
