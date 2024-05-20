namespace Memorabilia.Tests.Interfaces;

public interface IWithLevel
{
    Domain.Entities.Memorabilia SetItemLevel(LevelTypes levelType);
}
