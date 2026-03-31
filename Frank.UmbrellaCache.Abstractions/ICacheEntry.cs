namespace Frank.UmbrellaCache.Abstractions;

public interface ICacheEntry<T>
{
    T Value { get; }
    DateTimeOffset? ExpiresAt { get; }
}