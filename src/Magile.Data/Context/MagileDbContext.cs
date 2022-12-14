using System;
using Magile.Data.Mapping;
using Magile.Data.Mapping.Branchs;
using Magile.Data.Mapping.Cash;
using Magile.Data.Mapping.Categories;
using Magile.Data.Mapping.Departaments;
using Magile.Data.Mapping.Roles;
using Magile.Data.Mapping.Terms;
using Magile.Data.Mapping.Users;
using Magile.Domain.Entities.Branch;
using Magile.Domain.Entities.Cash;
using Magile.Domain.Entities.Categories;
using Magile.Domain.Entities.Departament;
using Magile.Domain.Entities.Role;
using Magile.Domain.Entities.Term;
using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Context
{
    public class MagileDbContext : DbContext
    {
        public DbSet<BranchEntity> Branches { get; set; }
        public DbSet<CashEntity> Cash { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<DepartamentEntity> Departaments { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<TermEntity> Terms { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public MagileDbContext(DbContextOptions<MagileDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BranchMap());
            modelBuilder.ApplyConfiguration(new CashMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new DepartamentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new TermMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserFinancialMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTermMap());
        }
    }
}