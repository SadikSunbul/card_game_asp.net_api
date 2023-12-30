using Via.Domain.Enums;

namespace Via.WebApi.Extensions;

public static class CacheExtensions
{
    /// <summary>
    /// Cach mekanizmasını seçiniz,configuration seçiniz ve appsetting içinden CacheConnections içinden bir gağlantı adresi seçiniz
    /// </summary>
    /// <param name="services"></param>
    /// <param name="cacheType"></param>
    /// <param name="configuration"></param>
    /// <param name="Connect"></param>
    /// <returns></returns>
    public static IServiceCollection AddCache(this IServiceCollection services, CacheType cacheType, IConfiguration configuration,string Connect=null)
    {
        var connection = configuration.GetSection("CacheConnections");
        switch (cacheType)
        {
            case CacheType.InMemory:
               services.AddDistributedMemoryCache();
                break;
            case CacheType.Redis:
               services.AddStackExchangeRedisCache(opt => opt.Configuration = connection[Connect]);
                break;
            default:
                break;
        }
        return services;
    }
}
