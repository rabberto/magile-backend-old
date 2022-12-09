using System;
using Magile.Data.Mapping;
using Magile.Domain.Entities.Branch;
using Magile.Domain.Entities.Role;
using Magile.Domain.Entities.Term;
using Magile.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Magile.Data.Context
{
    public class MagileDbContext : DbContext
    {
        public DbSet<BranchEntity> Branches { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<TermEntity> Terms { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public MagileDbContext(DbContextOptions<MagileDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BranchMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new TermMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}