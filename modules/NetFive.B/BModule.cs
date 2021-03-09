using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetFive.B.Abstractions.TestB;
using NetFive.B.TestB;
using NetFive.Infrastructure;

namespace NetFive.B
{
    public class BModule : IAppModule
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITestBService, TestBService>();
        }

        public void Configure(IApplicationBuilder app)
        {

        }
    }
}