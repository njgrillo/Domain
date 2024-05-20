namespace Memorabilia.Tests.Interfaces;

public interface IWithMultipleSports
{
    Domain.Entities.Memorabilia SetSports(params int[] sportIds);
}
