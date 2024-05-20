namespace Memorabilia.Tests.Interfaces;

public interface IWithMultiplePeople
{
    Domain.Entities.Memorabilia SetPerson(params int[] personIds);
}
