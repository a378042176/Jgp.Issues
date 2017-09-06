using Abp.AutoMapper;
using Jgp.Issues.Sessions.Dto;

namespace Jgp.Issues.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}