namespace Memorabilia.Domain.Constants;

public sealed class UserMessageStatuses : DomainItemConstants
{
    public static readonly UserMessageStatuses New = new(1, "New");
    public static readonly UserMessageStatuses Read = new(2, "Read");
    public static readonly UserMessageStatuses Deleted = new(3, "Deleted");

    public static readonly UserMessageStatuses[] All =
    [        
        New,
        Read,
        Deleted
    ];

    private UserMessageStatuses(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static UserMessageStatuses Find(int id)
        => All.SingleOrDefault(userMessageStatus => userMessageStatus.Id == id);
}
