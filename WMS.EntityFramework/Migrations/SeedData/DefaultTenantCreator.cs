using System.Linq;
using WMS.EntityFramework;
using WMS.MultiTenancy;

namespace WMS.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly WMSDbContext _context;

        public DefaultTenantCreator(WMSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
