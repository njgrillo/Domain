namespace Memorabilia.Domain.Constants;

public sealed class CardTypes : DomainItemConstants
{
    public static readonly CardTypes Trading = new(1, "Trading Card");
    public static readonly CardTypes Playing = new(2, "Playing Card");

    public static readonly CardTypes[] All =
    [
        Trading,
        Playing
    ];

    private CardTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static CardTypes Find(int id)
        => All.SingleOrDefault(CardType => CardType.Id == id);
}
