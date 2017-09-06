using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jgp.Issues.Companys
{
    public interface ICompanyRepository : IRepository<Company>
    {
        List<Company> GetAllCompany();
    }
}
