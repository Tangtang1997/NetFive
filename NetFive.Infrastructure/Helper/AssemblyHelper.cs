using Microsoft.Extensions.DependencyModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace NetFive.Infrastructure.Helper
{
    public class AssemblyHelper
    { 
        public static List<Assembly> ThisAssemblies
        {
            get
            { 
                var dependencyContext = DependencyContext.Default;
                var libraries = dependencyContext.CompileLibraries.Where(lib => !lib.Serviceable && lib.Type != "package" && lib.Name.StartsWith(nameof(NetFive)));
                return libraries.Select(lib => AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(lib.Name))).ToList();
            }
        }
    }
}