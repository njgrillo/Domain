namespace Memorabilia.Tests.Interfaces;

public interface IWithMultipleSports
{
    Entity.Memorabilia SetSports(params int[] sportIds);
}
