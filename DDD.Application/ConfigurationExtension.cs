using DDD.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Application
{
    public static class ConfigurationExtension
    {
        /// <summary>
        /// 添加应用服务
        /// </summary>
        /// <param name="services">服务容器</param>
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationService, ApplicationService>();
        }
    }
}
