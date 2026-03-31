namespace Frank.UmbrellaCache.Abstractions;

public interface IUmbrellaCache
{
    Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration, CancellationToken cancellationToken);
    
    Task RemoveAsync(string key, CancellationToken cancellationToken);
    
    Task<bool> TryRemoveAsync(string key, CancellationToken cancellationToken);
    
    Task ClearAsync(CancellationToken cancellationToken);
    
    Task<bool> TryGetAsync<T>(string key, out T value, CancellationToken cancellationToken);
}