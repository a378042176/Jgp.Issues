using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jgp.Issues.Companys
{
    [Table("Company")]
    public class Company : FullAuditedEntity
    {
        public virtual string CompanyName { get; set; }
      
        /// <summary>
        /// Default costructor.
        /// Assigns some default values to properties.
        /// </summary>
        public Company()
        {
            CreationTime = DateTime.Now;
        }
    }
}
