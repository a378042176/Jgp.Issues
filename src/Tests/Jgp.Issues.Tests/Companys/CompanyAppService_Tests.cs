using System.Linq;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using Shouldly;

using Xunit;
using Jgp.Issues.Tests;
using Jgp.Issues.Companys;

namespace SimpleTaskSystem.Test.Tasks
{
    public class CompanyAppService_Tests : IssuesTestBase
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyAppService_Tests()
        {
            _companyAppService = Resolve<ICompanyAppService>();

        }
        [Fact]
        public void Should_Get_Companys()
        {
            //Run SUT
            var output = _companyAppService.GetCompanys();

            //Checking results
            output.Companys.Count.ShouldBe(0);
            //output.Tasks.All(t => t.State == (byte)TaskState.Completed).ShouldBe(true);
        }

        [Fact]
        public void Should_CreateCompany_Test()
        {
            var initialTaskCount = UsingDbContext(context => context.Companys.Count());
            //Act
            _companyAppService.CreateCompany(new Jgp.Issues.Companys.Dtos.CreateCompanyDto()
            {
                CompanyName = "艾可思信息技术有限公司"
            });

            //Check results
            UsingDbContext(context =>
            {
                context.Companys.Count().ShouldBe(initialTaskCount + 1);
                var company = context.Companys.FirstOrDefault(t => t.CompanyName == "艾可思信息技术有限公司");
                company.ShouldNotBe(null);
            });
        }


    }
}
