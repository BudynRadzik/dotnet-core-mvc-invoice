using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Entities
{
    public class Company
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string TaxId { get; set; } = default!;
        public CompanyContactDetails ContactDetails { get; set; } = default!;
    }
}
