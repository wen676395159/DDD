using DDD.Core.Repositories;
using DDD.Core.Services;
using DDD.Infrastructure.Data.Repositories;
using DDD.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Infrastructure
{
    public static class ConfigurationExtension
    {
        /// <summary>
        /// 添加仓储
        /// </summary>
        /// <param name="services">服务容器</param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
        }

        /// <summary>
        /// 添加基础设施服务
        /// </summary>
        /// <param name="services">服务容器</param>
        public static void AddInfrastructures(this IServiceCollection services)
        {
            services.AddScoped<IFtpService, FtpService>();
        }
    }
}
