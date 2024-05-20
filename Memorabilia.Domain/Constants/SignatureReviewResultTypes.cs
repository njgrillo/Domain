namespace Memorabilia.Domain.Constants;

public sealed class SignatureReviewResultTypes : DomainItemConstants
{
    public static readonly SignatureReviewResultTypes LikelyAuthentic = new(1, "Likely Authentic");
    public static readonly SignatureReviewResultTypes UnlikelyAuthentic = new(2, "Unlikely Authentic");

    public static readonly SignatureReviewResultTypes[] All =
    [
        LikelyAuthentic,
        UnlikelyAuthentic
    ];

    private SignatureReviewResultTypes(int id, string name)
        : base(id, name) { }

    public static SignatureReviewResultTypes Find(int id)
        => All.SingleOrDefault(signatureReviewResultType => signatureReviewResultType.Id == id);
}
