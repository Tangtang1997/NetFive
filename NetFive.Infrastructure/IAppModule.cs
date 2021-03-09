using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NetFive.Infrastructure
{
    /// <summary>
    /// 模块抽象类
    /// </summary>
    public interface IAppModule
    {
        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);

        /// <summary>
        /// 配置管道
        /// </summary>
        /// <param name="app"></param>
        void Configure(IApplicationBuilder app);


    }
}