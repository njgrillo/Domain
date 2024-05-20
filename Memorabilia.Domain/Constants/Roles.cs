namespace Memorabilia.Domain.Constants;

public sealed class Roles : DomainItemConstants
{
    public static readonly Roles Admin = new(1, "Admin");
    public static readonly Roles Complimentary = new(2, "Complimentary");
    public static readonly Roles NonSubscriber = new(3, "Non Subscriber");
    public static readonly Roles Promoter = new(4, "Promoter");
    public static readonly Roles SubscriberTier1 = new(5, "Subscriber Tier 1");
    public static readonly Roles SubscriberTier2 = new(6, "Subscriber Tier 2");
    public static readonly Roles TestUser = new(7, "Test User");

    public static readonly Roles[] All =
    [            
        Admin,
        Complimentary,
        NonSubscriber,
        Promoter,
        SubscriberTier1,
        SubscriberTier2,
        TestUser
    ];

    public static readonly Roles[] HighestLevelRoles =
    [
        Admin,
        Complimentary,
        Promoter,
        TestUser
    ];

    public static readonly Roles[] MembershipRoles =
    [
        Promoter,
        SubscriberTier1,
        SubscriberTier2,
    ];

    private Roles(int id, string name) 
        : base(id, name) { }

    public static Roles Find(int id)
        => All.SingleOrDefault(role => role.Id == id);

    public static Roles FindByName(string name)
        => All.SingleOrDefault(role => role.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    public static bool IsMembershipRole(int roleId)
        => MembershipRoles.Any(role => role.Id == roleId);
}
