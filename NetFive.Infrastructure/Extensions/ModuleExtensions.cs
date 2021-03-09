using System.Linq;
using NetFive.Infrastructure;
using NetFive.Infrastructure.Helper;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ModuleExtensions
    {
        public static IServiceCollection ConfigureModule(this IServiceCollection services)
        {
            //  1:将所有模块中继承了IAppModule接口的类注册到容器中
            RegisterModule(services);

            //  2:通过IOC容器获取到所有module的实例，遍历执行它的方法
            RegisterServices(services);

            return services;
        }

        private static void RegisterModule(IServiceCollection services)
        {
            var assemblies = AssemblyHelper.ThisAssemblies;

            if (assemblies == null)
            {
                return;
            }

            foreach (var moduleType in assemblies.Select(assembly => assembly.GetTypes().FirstOrDefault(t => typeof(IAppModule).IsAssignableFrom(t))).Where(moduleType => moduleType != null && moduleType != typeof(IAppModule)))
            {
                services.AddSingleton(typeof(IAppModule), moduleType);
            }
        }

        public static void RegisterServices(IServiceCollection services)
        {
            foreach (var module in services.BuildServiceProvider().GetServices<IAppModule>())
            {
                module.ConfigureServices(services, TODO);
            }
        }
    }
}