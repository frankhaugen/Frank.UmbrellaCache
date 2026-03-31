using Frank.BedrockSlim.Client;
using Frank.UmbrellaCache.Abstractions;

namespace Frank.UmbrellaCache;

public class UmbrellaCache : IUmbrellaCache
{
    private readonly ITcpClient _tcpClient;

    public UmbrellaCache(ITcpClient tcpClient)
    {
        _tcpClient = tcpClient;
    }

    /// <inheritdoc />
    public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration, CancellationToken cancellationToken)
    {
        
    }

    /// <inheritdoc />
    public async Task RemoveAsync(string key, CancellationToken cancellationToken)
    {
    }

    /// <inheritdoc />
    public async Task<bool> TryRemoveAsync(string key, CancellationToken cancellationToken)
    {
        return false;
    }

    /// <inheritdoc />
    public async Task ClearAsync(CancellationToken cancellationToken)
    {
    }

    /// <inheritdoc />
    public async Task<bool> TryGetAsync<T>(string key, out T value, CancellationToken cancellationToken)
    {
        value = default;
        return false;
    }
}