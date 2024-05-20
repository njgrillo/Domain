namespace Memorabilia.Tests.Common;

public abstract class MemorabiliaTests : Tests
{
    protected static Domain.Entities.Memorabilia GetMemorabilia(ItemTypes itemType)
        => new(acquiredDate: null,
               acquiredWithAutograph: false,
               acquisitionTypeId: GetRandomNumber(),
               collections: [],
               conditionId: null,
               cost: null,
               denominator: null,
               estimatedValue: null,
               forTrade: false,
               framed: false,
               itemTypeId: itemType.Id,
               note: string.Empty,
               numerator: null,
               privacyTypeId: GetRandomNumber(),
               purchaseTypeId: null,
               userId: GetRandomNumber());    
}
