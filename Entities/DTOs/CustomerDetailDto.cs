using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto

    {
        public int UserId { get; set; }
        public int CompanyName { get; set; }
    }
}
