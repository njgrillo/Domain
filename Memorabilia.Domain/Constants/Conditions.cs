namespace Memorabilia.Domain.Constants;

public sealed class Conditions : DomainItemConstants
{  
    public static readonly Conditions Excellent = new(5, "Excellent");
    public static readonly Conditions Fair = new(6, "Fair");
    public static readonly Conditions GemMint = new(2, "Gem Mint");
    public static readonly Conditions Mint = new(3, "Mint");
    public static readonly Conditions NearMint = new(4, "Near Mint");
    public static readonly Conditions Poor = new(7, "Poor");
    public static readonly Conditions Pristine = new(1, "Pristine");
    public static readonly Conditions Unknown = new(11, "Unknown");

    public static readonly Conditions[] All =
    [
        Pristine,
        GemMint,
        Mint,
        NearMint,
        Excellent,
        Fair,
        Poor,
        Unknown
    ];

    private Conditions(int id, string name, string abbreviation = null) 
        : base(id, name, abbreviation) { }

    public static Conditions Find(int id)
        => All.SingleOrDefault(condition => condition.Id == id);

    public static Conditions Find(string name)
        => All.SingleOrDefault(condition => condition.Name == name);    
}
