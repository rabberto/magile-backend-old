using System;
using Magile.Data.Context;
using Magile.Data.Implementation;
using Magile.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Magile.CrossCuting.DependencyIntection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection service)
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IBranchRepository, BranchImplementation>();
            service.AddScoped<IRoleRepository, RoleImplementation>();
            service.AddScoped<ITermRepository, TermImplementation>();
            service.AddScoped<IUserRepository, UserImplementation>();
            service.AddScoped<IUserRoleRepository, UserRoleImplementation>();
            service.AddScoped<IUserTermRepository, UserTermImplementation>();

            service.AddDbContext<MagileDbContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbMagile;Uid=root;Pwd=develop1984",
                 new MySqlServerVersion(new Version(5, 7, 33))));
        }
    }
}