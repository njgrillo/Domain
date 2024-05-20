namespace Memorabilia.Domain.Constants;

public sealed class MemorabiliaItemSteps : DomainItemConstants
{
    public static readonly MemorabiliaItemSteps Detail = new(2, "Details");
    public static readonly MemorabiliaItemSteps Image = new(3, "Images");
    public static readonly MemorabiliaItemSteps Item = new(1, "Memorabilia");    

    public static readonly MemorabiliaItemSteps[] All =
    [
       Detail,
       Image,
       Item
    ];

    private MemorabiliaItemSteps(int id, string name) 
        : base(id, name) { }

    public static MemorabiliaItemSteps Find(int id)
        => All.SingleOrDefault(memorabiliaItemStep => memorabiliaItemStep.Id == id);
}
