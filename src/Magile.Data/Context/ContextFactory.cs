using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Magile.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MagileDbContext>
    {
        public MagileDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=MagileSinergas-hml;Uid=root;Pwd=develop1984";
            var optionsBuilder = new DbContextOptionsBuilder<MagileDbContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 7, 33)));
            return new MagileDbContext(optionsBuilder.Options);
        }
    }
}