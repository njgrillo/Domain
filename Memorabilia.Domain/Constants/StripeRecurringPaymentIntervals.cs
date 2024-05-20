namespace Memorabilia.Domain.Constants;

public sealed class StripeRecurringPaymentIntervals : DomainItemConstants
{
    public static readonly StripeRecurringPaymentIntervals Day = new(1, "day");
    public static readonly StripeRecurringPaymentIntervals Month = new(2, "month");
    public static readonly StripeRecurringPaymentIntervals Week = new(3, "week");
    public static readonly StripeRecurringPaymentIntervals Year = new(4, "year");

    public static readonly StripeRecurringPaymentIntervals[] All =
    [
        Day,
        Month,
        Week, 
        Year  
    ];

    private StripeRecurringPaymentIntervals(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }
}
