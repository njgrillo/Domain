namespace Memorabilia.Tests.Interfaces;

public interface IWithMultiplePeople
{
    Entity.Memorabilia SetPerson(params int[] personIds);
}
