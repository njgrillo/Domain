namespace Memorabilia.Tests.Interfaces;

public interface IWithMultipleTeams
{
    Entity.Memorabilia SetTeams(params int[] teamIds);
}
