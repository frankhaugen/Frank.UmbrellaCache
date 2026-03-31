namespace Frank.UmbrellaCache.Abstractions;

public static class UmbrellaCacheServiceExtensions
{
    public static Task<T> GetOrAddAsync<T>(this IUmbrellaCache cache, string key, Func<Task<T>> factory, TimeSpan? expiration)
        => cache.GetOrAddAsync(key, factory, expiration, CancellationToken.None);
    
    public static Task<T> GetOrAddAsync<T>(this IUmbrellaCache cache, string key, Func<Task<T>> factory, CancellationToken cancellationToken)
        => cache.GetOrAddAsync(key, factory, null, cancellationToken);
    
    public static Task<T> GetOrAddAsync<T>(this IUmbrellaCache cache, string key, Func<Task<T>> factory)
        => cache.GetOrAddAsync(key, factory, null, CancellationToken.None);
}