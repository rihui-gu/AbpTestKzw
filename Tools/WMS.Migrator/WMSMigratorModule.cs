using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using WMS.EntityFramework;

namespace WMS.Migrator
{
    [DependsOn(typeof(WMSDataModule))]
    public class WMSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<WMSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}