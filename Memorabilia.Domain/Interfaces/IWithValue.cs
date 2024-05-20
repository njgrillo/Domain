namespace Memorabilia.Domain.Interfaces;

public interface IWithValue<T>
{
    T Value { get; }
}
