namespace Frank.UmbrellaCache.Internals;

public class InternalCache
{
    public static Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration, CancellationToken cancellationToken)
    {
        return Task.FromResult(default(T));
    }

    public static Task RemoveAsync(string key, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public static Task<bool> TryRemoveAsync(string key, CancellationToken cancellationToken)
    {
        return Task.FromResult(false);
    }

    public static Task ClearAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public static Task<bool> TryGetAsync<T>(string key, out T value, CancellationToken cancellationToken)
    {
        value = default;
        return Task.FromResult(false);
    }
}