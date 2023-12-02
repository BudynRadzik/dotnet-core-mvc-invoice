using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Entities
{
    public class CompanyContactDetails
    {
         
        public string? City { get; set; } 
        public string? Street { get; set; } 
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; } 
    }
}
