using Magile.Domain.Interfaces;
using Magile.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Magile.CrossCuting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection service)
        {
            service.AddTransient<IBranchService, BranchService>();
            service.AddTransient<IRoleService, RoleService>();
            service.AddTransient<ITermService, TermService>();
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<IUserRoleService, UserRoleService>();
            service.AddTransient<IUserTermService, UserTermService>();
        }
    }
}