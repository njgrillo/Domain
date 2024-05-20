namespace Memorabilia.Domain.Constants;

public sealed class GloveTypes : DomainItemConstants
{
    public static readonly GloveTypes Baseball = new(1, "Baseball Glove");
    public static readonly GloveTypes Batting = new(2, "Batting Glove");
    public static readonly GloveTypes Football = new(3, "Football Glove");
    public static readonly GloveTypes Hockey = new(4, "Hockey Glove");
    public static readonly GloveTypes Boxing = new(5, "Boxing Glove");
    public static readonly GloveTypes MMA = new(5, "MMA Glove", "MMA");
    public static readonly GloveTypes Other = new(10, "Other");
    public static readonly GloveTypes Soccer = new(11, "Soccer");

    public static readonly GloveTypes[] All =
    [
        Baseball,
        Batting,
        Boxing,
        Football,
        Hockey,            
        MMA,
        Other,
        Soccer
    ];

    public static readonly GloveTypes[] BaseballTypes =
    [
        Baseball,
        Batting,
    ];

    private GloveTypes(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static GloveTypes Find(int id)
        => All.SingleOrDefault(gloveType => gloveType.Id == id);

    public static GloveTypes[] GetAll(params Sports[] sports)
    {
        var gloveTypes = new List<GloveTypes>(); 

        if (sports.Contains(Sports.Baseball))
            gloveTypes.AddRange(BaseballTypes);

        if (sports.Contains(Sports.Boxing))
            gloveTypes.Add(Boxing);

        if (sports.Contains(Sports.Football))
            gloveTypes.Add(Football);

        if (sports.Contains(Sports.Hockey))
            gloveTypes.Add(Hockey);

        if (sports.Contains(Sports.MixedMartialArts))
            gloveTypes.Add(MMA);

        if (sports.Contains(Sports.Soccer))
            gloveTypes.Add(Soccer);

        gloveTypes.Add(Other);

        return gloveTypes.OrderBy(x => x.Name)
                         .ToArray();
    }
}
