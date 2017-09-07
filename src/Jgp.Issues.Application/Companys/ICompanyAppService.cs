using Abp.Application.Services;
using Jgp.Issues.Companys.Dtos;
using System.Collections.Generic;

namespace Jgp.Issues.Companys
{
    /// <summary>
    /// 公司管理
    /// </summary>
    public interface ICompanyAppService : IApplicationService
    {
        /// <summary>
        /// 获取所有公司
        /// </summary>
        /// <returns></returns>
        GetCompanysOutput GetCompanys();
        /// <summary>
        /// 添加公司
        /// </summary>
        /// <param name="input"></param>
        void CreateCompany(CreateCompanyDto input);
    }
}
