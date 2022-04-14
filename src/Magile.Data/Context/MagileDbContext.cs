using System;
using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
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