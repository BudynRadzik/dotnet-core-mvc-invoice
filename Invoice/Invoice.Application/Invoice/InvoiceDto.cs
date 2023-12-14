using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Application.Invoice
{
    public class InvoiceDto
    {
        public string? Place { get; set; }
        public string? AccountNumber { get; set; }
        public string? Signature { get; set; }

    }
}
