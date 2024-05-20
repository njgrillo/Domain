namespace Memorabilia.Domain.Constants;

public sealed class PriorityTypes : DomainItemConstants
{
    public static readonly PriorityTypes MustHave = new(1, "Must Have");
    public static readonly PriorityTypes NiceToHave = new(2, "Nice to Have");
    public static readonly PriorityTypes NoWay = new(4, "No Way");
    public static readonly PriorityTypes TakeItOrLeaveIt = new(3, "Take it or Leave it");
    public static readonly PriorityTypes Watching = new(1004, "Watching");

    public static readonly PriorityTypes[] All =
    [
        MustHave,
        NiceToHave,
        NoWay,
        TakeItOrLeaveIt,
        Watching
    ];

    private PriorityTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static PriorityTypes Find(int id)
        => All.SingleOrDefault(priorityType => priorityType.Id == id);
}
