﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace Jgp.Issues.Companys.Dtos
{
    [AutoMapTo(typeof(Company))]
    public class CompanyDto : EntityDto
    {
        public string CompanyName { get; set; }
    }
}
