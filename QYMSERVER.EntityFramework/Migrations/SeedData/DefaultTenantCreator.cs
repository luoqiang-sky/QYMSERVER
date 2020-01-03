using System.Linq;
using QYMSERVER.EntityFramework;
using QYMSERVER.MultiTenancy;

namespace QYMSERVER.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly QYMSERVERDbContext _context;

        public DefaultTenantCreator(QYMSERVERDbContext context)
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
