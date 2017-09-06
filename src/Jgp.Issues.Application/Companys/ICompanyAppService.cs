using Abp.Application.Services;
using Jgp.Issues.Companys.Dtos;
using System.Collections.Generic;

namespace Jgp.Issues.Companys
{
    public interface ICompanyAppService : IApplicationService
    {
        GetCompanysOutput GetCompanys();
    }
}
