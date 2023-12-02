using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public string Place { get; set; } = default!;
        public string AccountNumber { get; set; } = default!;
        public string Signature { get; set; } = default!;
        public Company Companies { get; set; } = default!;
        public CompanyContactDetails CompanyContactDetails { get; set; } = default!;

    }
}
