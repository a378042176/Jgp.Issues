using System.Linq;
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

       
    }
}
