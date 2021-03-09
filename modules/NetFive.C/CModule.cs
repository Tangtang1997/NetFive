using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetFive.C.Abstractions.TestC;
using NetFive.C.TestC;
using NetFive.Infrastructure;

namespace NetFive.C
{
    public class CModule : IAppModule
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CConfig>(configuration.GetSection(""));

            services.AddScoped<ITestCService, TestCService>();
        }

        public void Configure(IApplicationBuilder app)
        {

        }
    }
}