using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        Task Create(Domain.Entities.Invoice invoice);
        Task<IEnumerable<Domain.Entities.Invoice>> GetAll();
    }
}
