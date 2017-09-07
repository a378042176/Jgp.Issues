using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Jgp.Issues.Companys;
using Jgp.Issues.Companys.Dtos;
using Abp.AutoMapper;
using Jgp.Issues.Authorization;

namespace Jgp.Issues.Companys
{
    [AbpAuthorize(PermissionNames.Pages_Companys)]
    public class CompanyAppService : ApplicationService, ICompanyAppService
    {
        private readonly IRepository<Company> _companyRepository;
        public CompanyAppService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public GetCompanysOutput GetCompanys()
        {
            var companys = _companyRepository.GetAll();

            return new GetCompanysOutput
            {
                Companys = companys.MapTo<List<CompanyDto>>()
            };
        }

        public void CreateCompany(CreateCompanyDto input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);

            //Creating a new Task entity with given input's properties
            var task = input.MapTo<Company>();


            //Saving entity with standard Insert method of repositories.
            _companyRepository.Insert(task);
        }
    }
}