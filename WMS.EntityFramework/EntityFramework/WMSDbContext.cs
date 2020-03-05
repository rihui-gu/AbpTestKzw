﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using WMS.Authorization.Roles;
using WMS.Authorization.Users;
using WMS.MultiTenancy;

namespace WMS.EntityFramework
{
    public class WMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WMSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WMSDbContext since ABP automatically handles it.
         */
        public WMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WMSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WMSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        /// <summary>
        /// 订单表
        /// </summary>
        public IDbSet<Orders.Order> Orders { get; set; }
    }
}
