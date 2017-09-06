using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Jgp.Issues.EntityFramework;

namespace Jgp.Issues
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(IssuesCoreModule))]
    public class IssuesDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<IssuesDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
