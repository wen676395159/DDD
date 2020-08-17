using DDD.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core
{
    public static class ConfigurationExtension
    {
        /// <summary>
        /// 添加领域服务
        /// </summary>
        /// <param name="services">服务容器</param>
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IDomainService, DomainService>();
        }
    }
}
