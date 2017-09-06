using Jgp.Issues.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Jgp.Issues.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly IssuesDbContext _context;

        public InitialHostDbBuilder(IssuesDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
