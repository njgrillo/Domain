namespace Memorabilia.Tests.Common;

public abstract class Tests
{
    protected static int GetRandomNumber()
        => new Random().Next();
}
