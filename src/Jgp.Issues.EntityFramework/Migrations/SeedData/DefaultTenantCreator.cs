using System.Linq;
using Jgp.Issues.EntityFramework;
using Jgp.Issues.MultiTenancy;

namespace Jgp.Issues.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly IssuesDbContext _context;

        public DefaultTenantCreator(IssuesDbContext context)
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
