namespace Memorabilia.Domain.Constants;

public sealed class PaymentOptions : DomainItemConstants
{
    public static readonly PaymentOptions PayPal = new(1, "PayPal");
    public static readonly PaymentOptions Venmo = new(2, "Venmo");
    public static readonly PaymentOptions CashApp = new(3, "Cash App", "CA");
    public static readonly PaymentOptions Zelle = new(4, "Zelle");

    public static readonly PaymentOptions[] All =
    [
        PayPal,
        Venmo,
        CashApp, 
        Zelle
    ];

    private PaymentOptions(int id, string name, string abbreviation = null)
        : base(id, name, abbreviation) { }

    public static PaymentOptions Find(int id)
        => All.SingleOrDefault(paymentOption => paymentOption.Id == id);
}
