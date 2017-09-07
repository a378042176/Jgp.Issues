using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace Jgp.Issues.Companys.Dtos
{
    /// <summary>
    /// 创建公司Dto
    /// </summary>
    [AutoMapTo(typeof(Company))]
    public class CreateCompanyDto
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [StringLength(64)]
        public string CompanyName { get; set; }
    }
}
