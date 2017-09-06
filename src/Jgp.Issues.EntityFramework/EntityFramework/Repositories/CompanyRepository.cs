using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Jgp.Issues.Companys;

namespace Jgp.Issues.EntityFramework.Repositories
{
    public class CompanyRepository : IssuesRepositoryBase<Company>, ICompanyRepository
    {
        protected CompanyRepository(IDbContextProvider<IssuesDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Company> GetAllCompany()
        {
            var query = GetAll();
            return query.ToList();
        }
    }
}
