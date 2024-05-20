namespace Memorabilia.Domain.Constants;

public sealed class MembershipPaymentTypes : DomainItemConstants
{
    public static readonly MembershipPaymentTypes OneTime = new(1, "Try for one month");
    public static readonly MembershipPaymentTypes Recurring = new(2, "Enroll in auto-renewal");

    public static readonly MembershipPaymentTypes[] All =
    [
        OneTime,
        Recurring
    ];

    private MembershipPaymentTypes(int id, string name)
        : base(id, name) { }
}
