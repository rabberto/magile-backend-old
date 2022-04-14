using Magile.Domain.Interfaces;
using Magile.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Magile.CrossCuting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBranchService, BranchService>();
            serviceCollection.AddTransient<IRoleService, RoleService>();
            serviceCollection.AddTransient<ITermService, TermService>();
            serviceCollection.AddTransient<IUserRoleService, UserRoleService>();
            serviceCollection.AddTransient<IUserTermService, UserTermService>();
        }
    }
}