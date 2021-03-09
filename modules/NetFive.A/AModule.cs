using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetFive.A.Abstractions.TestA;
using NetFive.A.TestA;
using NetFive.Infrastructure;

namespace NetFive.A
{
    public class AModule : IAppModule
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITestAService, TestAService>();
        }

        public void Configure(IApplicationBuilder app)
        {

        }
    }
}