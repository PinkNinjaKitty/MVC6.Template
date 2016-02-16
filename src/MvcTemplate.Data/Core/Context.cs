﻿using Microsoft.Data.Entity;
using MvcTemplate.Data.Mapping;
using MvcTemplate.Objects;

namespace MvcTemplate.Data.Core
{
    public class Context : DbContext
    {
        #region Administration

        protected DbSet<Role> Roles { get; set; }
        protected DbSet<Account> Accounts { get; set; }
        protected DbSet<Permission> Permissions { get; set; }
        protected DbSet<RolePermission> RolePermissions { get; set; }

        #endregion

        #region System

        protected DbSet<Log> Logs { get; set; }

        #endregion

        static Context()
        {
            ObjectMapper.MapObjects();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Mvc6Template;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
