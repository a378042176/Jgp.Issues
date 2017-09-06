using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using Jgp.Issues.Companys;
using Jgp.Issues.Companys.Dtos;
using Abp.AutoMapper;

namespace Jgp.Issues.Companys
{

    public class CompanyAppService : ApplicationService, ICompanyAppService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyAppService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public GetCompanysOutput GetCompanys()
        {
            var companys = _companyRepository.GetAll();

            return new GetCompanysOutput
            {
                Companys = Mapper.Map<List<CompanyDto>>(companys)
            };
        }
    }
}