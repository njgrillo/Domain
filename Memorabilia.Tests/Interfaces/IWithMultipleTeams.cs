namespace Memorabilia.Tests.Interfaces;

public interface IWithMultipleTeams
{
    Domain.Entities.Memorabilia SetTeams(params int[] teamIds);
}
