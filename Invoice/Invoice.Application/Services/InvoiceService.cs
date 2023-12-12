using Invoice.Domain.Interfaces;

namespace Invoice.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public async Task Create(Domain.Entities.Invoice invoice)
        {
            
            await _invoiceRepository.Create(invoice);
        }
    }
}
